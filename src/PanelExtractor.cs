using AForge.Imaging.Filters;
using ComicStripToKindle.ComicsPages;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.PanelExtraction;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using Image = AForge.Imaging.Image;

namespace ComicStripToKindle
{
    public class PanelExtractor
    {
        private ElectronicReaderProfile ElectronicReaderProfile { get; set; }
        private ComicConversionProfile ComicConversionProfile { get; set; }
        private ImageEnhancementProfile ImageEnhancementProfile { get; set; }

        public PanelExtractor(
            ElectronicReaderProfile electronicReaderProfile,
            ComicConversionProfile comicConversionProfile,
            ImageEnhancementProfile imageEnhancementProfile)
        {
            ElectronicReaderProfile = electronicReaderProfile;
            ComicConversionProfile = comicConversionProfile;
            ImageEnhancementProfile = imageEnhancementProfile;
        }

        public ExtractedPanelResults SavePanelsAsFiles(ExtractedPageResult extractedPage)
        {
            var panelBitmaps = ExtractPanelsFromComicImagePage(extractedPage.ExtractedPagePath);

            try
            {
                panelBitmaps = Rotate(panelBitmaps);
            }
            catch (System.ArgumentException)
            {//ToDO: Log error
                return new ExtractedPanelResults
                {
                    ExtractedPage = extractedPage,
                    ExtractedPanels = new List<ExtractedPanelResult>(),
                    TemporaryDirectory = ""
                };
            }

            var enhancedPanelImages = EnhancePanelImages(panelBitmaps);
            //panelBitmaps.Clear();

            var imageFileInfo = new FileInfo(extractedPage.ExtractedPagePath);
            var tempOutputDirectory = FileSystemUtilities.CreateTemporaryDirectory();

            var extractedPanels = SavePanelsAsJpegFiles(enhancedPanelImages, tempOutputDirectory, imageFileInfo);

            return new ExtractedPanelResults
            {
                ExtractedPage = extractedPage,
                ExtractedPanels = extractedPanels,
                TemporaryDirectory = tempOutputDirectory
            };
        }

        public List<Bitmap> ExtractPanels(ExtractedPageResult extractedPage)
        {
            Debug.WriteLine($"Page {extractedPage.PageNumber}");
            return ExtractPanelsFromComicImagePage(extractedPage.ExtractedPagePath);
        }

        private List<Bitmap> ExtractPanelsFromComicImagePage(string imagePath)
        {
            try
            {

                using (var image = Image.FromFile(imagePath))
                {

                    List<Bitmap> bitmaps = BitmapPanelExtractionFactory
                        .Build(ComicConversionProfile.PanelDetectionAlgorithm)
                        .ExtractPanelsFromComicImagePage(image, ComicConversionProfile);

                    //Validate bitmaps
                    List<Bitmap> validatedBitmaps = new List<Bitmap>();
                    foreach (var bitmap in bitmaps)
                    {
                        try
                        {
                            var width = bitmap.Width;

                            validatedBitmaps.Add(bitmap);
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }

                    return validatedBitmaps;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return new List<Bitmap>();
            }
        }

        private List<ExtractedPanelResult> SavePanelsAsJpegFiles(
            List<Bitmap> enhancedPanelImages,
            string tempOutputDirectory,
            FileInfo imageFileInfo)
        {
            var extractedPanels = new List<ExtractedPanelResult>();

            for (var i = 0; i < enhancedPanelImages.Count; i++)
            {
                var panelFilePath = $"{tempOutputDirectory}\\{imageFileInfo.Name.Substring(0, imageFileInfo.Name.Length - imageFileInfo.Extension.Length)}-{i + 1}{imageFileInfo.Extension}";

                enhancedPanelImages[i].SaveToJpegFile(panelFilePath, ImageEnhancementProfile.JpegQuality);

                enhancedPanelImages[i].Dispose();

                extractedPanels.Add(new ExtractedPanelResult
                {
                    ExtractedPanelPath = panelFilePath,
                    PanelNumber = i
                });
            }
            return extractedPanels;
        }

        private List<Bitmap> Rotate(List<Bitmap> panelBitmaps)
        {
            var rotatedPanels = new List<Bitmap>();

            if (panelBitmaps == null || panelBitmaps.Count == 0)
                return rotatedPanels;

            if (!ImageEnhancementProfile.AutomaticRotation)
                return panelBitmaps;

            var averagePanelRatio = panelBitmaps.Average(x => x.Width / (float)x.Height);
            var max = panelBitmaps.Max(x => x.Width / (float)x.Height);
            var min = panelBitmaps.Min(x => x.Width / (float)x.Height);

            Debug.WriteLine($"averagePanelRatio: {averagePanelRatio} - max: {max} - min: {min}");

            var electronicReaderRatio = ElectronicReaderProfile.HorizontalResolution / (float)ElectronicReaderProfile.VerticalResolution;

            //Rotate 90° panels if most of the panels on this page best fit rotation
            var rotateAllPanels = averagePanelRatio > electronicReaderRatio;
            Debug.WriteLine($"rotateAllPanels: {rotateAllPanels}");

            foreach (var panelBitmap in panelBitmaps)
            {
                float panelRatio = panelBitmap.Width / (float)panelBitmap.Height;
                Debug.WriteLine($"panelRatio: {panelRatio}");

                if (rotateAllPanels)
                {
                    //panelRatio = panelBitmap.VerticalResolution / (float)panelBitmap.HorizontalResolution;
                    if (panelRatio <= electronicReaderRatio / (float)2)//do not rotate
                    {
                        Debug.WriteLine($"panelRatio: {panelRatio} < electronicReaderRatio {electronicReaderRatio}/2");
                        rotatedPanels.Add(panelBitmap);
                    }
                    else
                    {
                        Debug.WriteLine($"Rotate");
                        rotatedPanels.Add(ImageFilters.Rotate(panelBitmap, ImageEnhancementProfile.RotationAngle));
                    }
                }
                else
                {
                    if (panelRatio >= 2 * electronicReaderRatio)
                    {
                        Debug.WriteLine($"panelRatio: {panelRatio} > electronicReaderRatio {electronicReaderRatio}*2");
                        rotatedPanels.Add(ImageFilters.Rotate(panelBitmap, ImageEnhancementProfile.RotationAngle));
                    }
                    else
                    {
                        Debug.WriteLine($"Do not Rotate");
                        rotatedPanels.Add(panelBitmap);
                    }
                }
            }
            return rotatedPanels;
        }

        private List<Bitmap> EnhancePanelImages(List<Bitmap> panels)
        {
            var images = new List<Bitmap>();
            foreach (var panel in panels)
            {
                var image = panel;

                try
                {
                    var resized = Resize(panel);

                    GammaCorrection(ref resized);

                    image = resized;

                    if (ElectronicReaderProfile.Grayscale)
                    {
                        image = ImageFilters.ConvertToGrayscaleBT709(resized);
                        //resized.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"EnhancePanelImages Resize + gamma exception: {ex}");
                }

                try
                {
                    LevelThreshold(ref image);
                    ContrastStretch(ref image);
                    GaussianSharpen(ref image);
                    Sharpen(ref image);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"EnhancePanelImages exception: {ex}");
                }
                images.Add(image);
                //resized.Dispose();
            }

            return images;
        }

        public Bitmap EnhancePanelImagePreview(Bitmap image, out long sizeInBytes)
        {
            var img = (Bitmap)image.Clone();
            GammaCorrection(ref img);

            img = ConvertToGrayscale(img);
            LevelThreshold(ref img);
            ContrastStretch(ref img);
            GaussianSharpen(ref img);
            Sharpen(ref img);
            img = ApplyJpegCompression(img, out sizeInBytes);
            return img;
        }

        public Bitmap ConvertToGrayscale(Bitmap image)
        {
            if (!ElectronicReaderProfile.Grayscale)
                return image;

            return ImageFilters.ConvertToGrayscaleBT709(image);
        }

        public void ContrastStretch(ref Bitmap image)
        {
            if (ImageEnhancementProfile.AutomaticContrastCorrection)
                ImageFilters.ContrastStretch(ref image);
        }

        public void LevelThreshold(ref Bitmap image)
        {
            if (ImageEnhancementProfile.LevelThreshold)
                ImageFilters.LevelTresholdInPlace(ref image, ImageEnhancementProfile.WhiteLevel, ImageEnhancementProfile.BlackLevel);
        }

        public Bitmap Resize(Bitmap image)
        {
            return ImageFilters.Resize(image, ElectronicReaderProfile.VerticalResolution, ElectronicReaderProfile.HorizontalResolution);
        }

        private Bitmap DetectConnectedComponentsLabelling(Bitmap image)
        {
            // create filter
            var filter = new ConnectedComponentsLabeling();
            // apply the filter
            var newImage = filter.Apply(image);

            return newImage;
        }

        private void GammaCorrection(ref Bitmap image)
        {
            if (ElectronicReaderProfile.GammaCorrection.HasValue)
                ImageFilters.GammaCorrectionInPlace(ref image, ElectronicReaderProfile.GammaCorrection.Value);
        }


        private void GaussianSharpen(ref Bitmap image)
        {
            if (ImageEnhancementProfile.GaussianSharpen)
                ImageFilters.GaussianSharpen(ref image, ImageEnhancementProfile.Sigma, ImageEnhancementProfile.Kernel);
        }

        private void Sharpen(ref Bitmap image)
        {
            if (ImageEnhancementProfile.Sharpen)
                ImageFilters.Sharpen(ref image);
        }

        private Bitmap ApplyJpegCompression(Bitmap image, out long sizeInBytes)
        {
            return image.ApplyToJpegCompression(ImageEnhancementProfile.JpegQuality, out sizeInBytes);
        }
    }
}
