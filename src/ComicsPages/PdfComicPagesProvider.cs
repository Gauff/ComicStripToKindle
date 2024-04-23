using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStripToKindle.ComicsPages
{
    class PdfComicPagesProvider : ComicPagesProvider
    {
        public PdfComicPagesProvider(string comicPagesSourceFilePath, bool unSkew, bool verticalSplit)
            : base(comicPagesSourceFilePath, unSkew, verticalSplit)
        {
        }

        public override ComicPages ExtractRandomPage()
        {
            string tempDirectory = null;

            try
            {
                tempDirectory = tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();

                var pdfExtractor = new PdfExtractor();
                var result = pdfExtractor.ExtractRandomImagesFromPdf(ComicPagesSourceFilePath, tempDirectory);

                return new ComicPages
                {
                    Pages = new List<ExtractedPageResult> { result },
                    TemporaryExtractedPagesDirectoryPath = tempDirectory,
                    SourceComicArchivePath = ComicPagesSourceFilePath
                };
            }
            catch
            {
                if (!string.IsNullOrEmpty(tempDirectory) && Directory.Exists(tempDirectory))
                    Directory.Delete(tempDirectory, true);

                throw;
            }
        }

        public override ComicPages ExtractPages()
        {
            string tempDirectory = null;

            try
            {
                tempDirectory = tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();

                var pdfExtractor = new PdfExtractor();
                var results = pdfExtractor.ExtractImagesFromPdf(ComicPagesSourceFilePath, tempDirectory);

                var pageSplitResults = new List<ExtractedPageResult>();

                foreach (var extractedPageResult in results
                    .Where(x => !string.IsNullOrEmpty(x.ExtractedPagePath)))
                {
                    var pages = VerticalSplitPage(extractedPageResult.ExtractedPagePath);

                    pageSplitResults.AddRange(
                        pages.Select(path => new ExtractedPageResult
                        {
                            Exception = extractedPageResult.Exception,
                            PageNumber = extractedPageResult.PageNumber,
                            ExtractedPagePath = path
                        }));
                }

                var comicFilePaths = pageSplitResults
                    .Where(x => !string.IsNullOrEmpty(x.ExtractedPagePath))
                    .Select(x => x.ExtractedPagePath);

                Parallel.ForEach(
                    comicFilePaths,
                    DegreeOfParallelism.AllProcessorsButOne,
                    (currentFile) =>
                    {
                        UnSkewPage(currentFile);
                    });

                return new ComicPages
                {
                    Pages = pageSplitResults,
                    TemporaryExtractedPagesDirectoryPath = tempDirectory,
                    SourceComicArchivePath = ComicPagesSourceFilePath
                };
            }
            catch
            {
                if (!string.IsNullOrEmpty(tempDirectory) && Directory.Exists(tempDirectory))
                    Directory.Delete(tempDirectory, true);

                throw;
            }
        }
    }
}
