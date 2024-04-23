using ComicStripToKindle.ComicsPages;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStripToKindle.Pdf
{
    public class KindleConverter
    {
        public class ConversionProgressEventArgs : EventArgs
        {
            public string SourceFilePath { get; set; }
            public float Percentage { get; set; }
            public string Description { get; set; }

            public ComicPages Pages { get; set; }
            public List<ExtractedPanelResults> Panels { get; set; }
        }

        public event EventHandler<ConversionProgressEventArgs> Progression;
        readonly string _sourceFilePath;              //Comic source file (PDF, CBR, CBZ)

        public KindleConverter(string sourceFilePath)
        {
            _sourceFilePath = sourceFilePath;
        }

        public string ConvertComicToKindlePdf(
            string outputPath,
            ElectronicReaderProfile electronicReaderProfile,
            ComicConversionProfile comicConversionProfile,
            ImageEnhancementProfile imageEnhancementProfile)
        {
            float progressionPercentage = 1;
            const int pageExtractionPercentage = 30;
            const int writePdfFilePercentage = 10;
            const int cleaningPercentage = 10;

            OnConversionProgress(progressionPercentage, "Extracting pages", null, null);

            ComicPages sourcePages;
            {
                //Comic panels extracted as JPG files
                var comicsPageProvider = ComicPagesFactory.Build(
                    _sourceFilePath,
                    comicConversionProfile.UnSkew,
                    comicConversionProfile.VerticalSplit);
                comicsPageProvider.Progression += ComicsPageProvider_Progression;
                sourcePages = comicsPageProvider.ExtractPages();
            }

            progressionPercentage += pageExtractionPercentage;
            OnConversionProgress(progressionPercentage, "Extract and enhance panels", sourcePages, null);

            var extractedPanelsByPageNumber = new Dictionary<int, ExtractedPanelResults>();//Page number, panels
            var pagePercentage = (100 - pageExtractionPercentage - writePdfFilePercentage - cleaningPercentage) / (float)sourcePages.Pages.Count;
            var sourcePageProcessedCount = 0;

            var pages = sourcePages.Pages.Where(x => !string.IsNullOrEmpty(x.ExtractedPagePath)).ToList();
            var orderedPages = OrderPages(pages, comicConversionProfile.InvertPages);

            var panelExtractor = new PanelExtractor(electronicReaderProfile, comicConversionProfile, imageEnhancementProfile);

            Parallel.ForEach(
                orderedPages,
                DegreeOfParallelism.AllProcessorsButOne,
                (page) =>
                {
                    extractedPanelsByPageNumber.Add(
                        page.PageNumber,
                        panelExtractor.SavePanelsAsFiles(page));

                    progressionPercentage += pagePercentage;
                    sourcePageProcessedCount++;
                    OnConversionProgress(
                        progressionPercentage,
                        $"Extract and enhance panels: {sourcePageProcessedCount}/{sourcePages.Pages.Count}",
                        sourcePages,
                        extractedPanelsByPageNumber.Values.ToList());
                });

            //foreach (var page in orderedPages)
            //{
            //    //Fire Progression Event
            //    extractedPanels.Add(
            //        new PanelExtractor(electronicReaderProfile, comicConversionProfile, imageEnhancementProfile)
            //        .SavePanelsAsFiles(page));

            //    progressionPercentage += pagePercentage;
            //    sourcePageProcessedCount++;
            //    OnConversionProgress(
            //        progressionPercentage, 
            //        $"Extract and enhance panels: {sourcePageProcessedCount}/{sourcePages.Pages.Count}", 
            //        sourcePages,
            //        extractedPanels);
            //}

            var fi = new FileInfo(_sourceFilePath);
            var filenameWithoutExtension = fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
            var convertedKindlePdfFilePath = $"{outputPath}\\{filenameWithoutExtension}.PDF";

            var extractedPanels = extractedPanelsByPageNumber
               .Where(x => x.Value != null)
               .Select(x => x.Key)
               .OrderBy(x => x)
               .SelectMany(x => extractedPanelsByPageNumber[x].ExtractedPanels)
               .ToList();

            var extractedPanelPaths = extractedPanels
                .Select(x => x.ExtractedPanelPath)
                .ToList();

            OnConversionProgress(progressionPercentage, "Write PDF", sourcePages, extractedPanelsByPageNumber.Values.ToList());

            new PdfWriter().WritePdf(extractedPanelPaths, convertedKindlePdfFilePath);

            progressionPercentage += writePdfFilePercentage;
            OnConversionProgress(progressionPercentage, "Delete Temporary files", sourcePages, extractedPanelsByPageNumber.Values.ToList());

            DeleteTemporaryFiles(sourcePages, extractedPanelsByPageNumber.Values.ToList());

            OnConversionProgress(100, "Done", sourcePages, extractedPanelsByPageNumber.Values.ToList());

            return convertedKindlePdfFilePath;
        }

        private void ComicsPageProvider_Progression(object sender, ComicPagesProvider.ComicPagesProviderProgressEventArgs e)
        {
            OnConversionProgress(e.Percentage, e.Description, null, null);

        }

        private List<ExtractedPageResult> OrderPages(List<ExtractedPageResult> pages, bool invertPages)
        {
            var orderedPages = new List<ExtractedPageResult>();

            if (invertPages)
            {
                orderedPages.Add(pages[0]);

                var i = 1;
                while (orderedPages.Count + 1 < pages.Count)
                {
                    orderedPages.Add(pages[i + 1]);
                    orderedPages.Add(pages[i]);

                    i = i + 2;
                }

                if (orderedPages.Count < pages.Count)
                    orderedPages.Add(pages[i]);
            }
            else
                orderedPages.AddRange(pages);

            return orderedPages;
        }

        private void DeleteTemporaryFiles(ComicPages SourcePages, List<ExtractedPanelResults> ExtractedPanels)
        {
            try
            {
                Directory.Delete(SourcePages.TemporaryExtractedPagesDirectoryPath, true);
            }
            catch
            {
                Debug.WriteLine($"Could not delete {SourcePages.TemporaryExtractedPagesDirectoryPath} temporary directory.");
            }

            foreach (var TemporaryDirectoryPath in ExtractedPanels.Select(x => x.TemporaryDirectory))
            {
                try
                {
                    Directory.Delete(TemporaryDirectoryPath, true);
                }
                catch
                {
                    Debug.WriteLine($"Could not delete {TemporaryDirectoryPath} temporary directory.");
                }
            }
        }

        protected virtual void OnConversionProgress(float percentage, string description, ComicPages pages, List<ExtractedPanelResults> panels)
        {
            Progression?.Invoke(this, new ConversionProgressEventArgs
            {
                SourceFilePath = _sourceFilePath,
                Percentage = percentage,
                Description = description,
                Pages = pages,
                Panels = panels
            });
        }
    }
}
