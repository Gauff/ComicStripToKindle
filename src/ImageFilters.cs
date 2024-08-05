using AForge.Imaging.Filters;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace ComicStripToKindle
{
    using AForge;
    using AForge.Imaging;
    using AForge.Imaging.ColorReduction;
    using Extensions;
    using System.Collections.Generic;

    public static class ImageFilters
    {
        public static Bitmap ProcessImageForPanelBlobExtraction(Bitmap image, int whiteBackgroundTreshold, bool blackBackground)
        {
            var imageCopy = AForge.Imaging.Image.Clone(image, PixelFormat.Format24bppRgb);

            imageCopy = ConvertToGrayscaleBT709(imageCopy);

            new Threshold(whiteBackgroundTreshold).ApplyInPlace(imageCopy);

            if (blackBackground)
                return imageCopy;

            new Invert().ApplyInPlace(imageCopy);
            //imageCopy.Save(@"c:\temp\inverted.bmp", ImageFormat.Bmp);

            return imageCopy;
        }

        public static Bitmap ConvertToGrayscaleBT709(Bitmap image)
        {
            if (image.PixelFormat == PixelFormat.Format8bppIndexed)
                return image;

            //Red: 0.2125;
            //Green: 0.7154;
            //Blue: 0.0721.
            return Grayscale.CommonAlgorithms.BT709.Apply(image);
        }

        public static Bitmap SkewCheck(string filePath, float absoluteAngleLimit = 10)
        {
            var bitmap = AForge.Imaging.Image.FromFile(filePath);

            return SkewCheck(bitmap, absoluteAngleLimit);
        }

        public static List<string> VerticalSplit(string filePath)
        {
            List<Bitmap> splitBitmaps;
            using (var bitmap = AForge.Imaging.Image.FromFile(filePath))
            {
                splitBitmaps = VerticalSplit(bitmap);
            }

            if (splitBitmaps.Count == 1)
                return new List<string> { filePath };

            var filePath1 = FileSystemUtilities.AppendToFileName(filePath, "1");
            var filePath2 = FileSystemUtilities.AppendToFileName(filePath, "2");

            splitBitmaps[0].SaveToTiffFile(filePath1);
            splitBitmaps[1].SaveToTiffFile(filePath2);

            return new List<string> { filePath1, filePath2 };
        }

        public static Bitmap SkewCheck(Bitmap bitmap, float absoluteAngleLimit = 13)
        {
            double angle;
            using (var grayScaleBitmap = ConvertToGrayscaleBT709(bitmap))
            {
                // create instance of skew checker
                var skewChecker = new DocumentSkewChecker { MaxSkewToDetect = absoluteAngleLimit };

                // get documents skew angle
                angle = skewChecker.GetSkewAngle(grayScaleBitmap);
            }

            if ((int)angle == 0)
                return bitmap;

            if (Math.Abs(angle) > absoluteAngleLimit)
            {
                Debug.WriteLine($"Skewcheck: angle > {absoluteAngleLimit}: {angle}");
                return bitmap;
            }

            // create rotation filter
            var rotationFilter = new RotateBilinear(-angle) { FillColor = Color.White };

            if (bitmap.PixelFormat == PixelFormat.Format8bppIndexed || bitmap.PixelFormat == PixelFormat.Format24bppRgb)
                return rotationFilter.Apply(bitmap);
            else
                return rotationFilter.Apply(AForge.Imaging.Image.Clone(bitmap, PixelFormat.Format24bppRgb));
        }
        public static Bitmap Invert(Bitmap image)
        {
            // create filter
            var filter = new Invert();
            // apply the filter
            return filter.Apply(image);
        }

        public static Bitmap Rotate(Bitmap image, float angle)
        {
            RotateBilinear filter = new RotateBilinear(angle, false);
            return filter.Apply(image);
        }

        public static Bitmap Resize(Bitmap image, int verticalResolution, int horizontalResolution)
        {
            var maxNewHeight = verticalResolution;
            var maxNewWidth = horizontalResolution;

            var scaleHeight = maxNewHeight / (float)image.Height;
            var scaleWidth = maxNewWidth / (float)image.Width;

            var scale = Math.Min(scaleHeight, scaleWidth);

            var filter = new ResizeBilinear((int)(image.Width * scale), (int)(image.Height * scale));

            return filter.Apply(image);
        }

        public static Bitmap AddWhiteBorder(string filePath)
        {
            using (var image = AForge.Imaging.Image.FromFile(filePath))
            {
                return AddWhiteBorder(image);
            }
        }

        public static Bitmap AddWhiteBorder(Bitmap image)
        {
            var borderWidthInPixels = 10;

            var newWidth = (image.Width + (2 * borderWidthInPixels));
            var newHeight = (image.Height + (2 * borderWidthInPixels));

            var newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gfx = Graphics.FromImage(newImage))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                gfx.FillRectangle(brush, 0, 0, newWidth, newHeight);
            }

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, borderWidthInPixels, borderWidthInPixels, image.Width, image.Height);

            return newImage;
        }

        public static Bitmap GammaCorrection(Bitmap image, double gammaCorrection)
        {
            // create filter
            var filter = new GammaCorrection(gammaCorrection);
            // apply the filter
            return filter.Apply(image);
        }

        public static void GammaCorrectionInPlace(ref Bitmap image, double gammaCorrection)
        {
            // create filter
            var filter = new GammaCorrection(gammaCorrection);

            filter.AssertCanApply(image.PixelFormat);

            // apply the filter
            filter.ApplyInPlace(image);
        }

        public static Bitmap ReduceColors(Bitmap image, int numColors)
        {
            // create color image quantization routine
            ColorImageQuantizer ciq = new ColorImageQuantizer(new MedianCutQuantizer());
            // create 256 colors table
            Color[] colorTable = ciq.CalculatePalette(image, numColors);
            // create dithering routine
            OrderedColorDithering dithering = new OrderedColorDithering();
            dithering.ColorTable = colorTable;
            // apply the dithering routine
            return dithering.Apply(image);
        }

        public static Bitmap GrayscaleToRgb(Bitmap image)
        {
            // create filter
            GrayscaleToRGB filter = new GrayscaleToRGB();
            // apply the filter
            return filter.Apply(image);
        }
        public static void ContrastStretch(ref Bitmap image)
        {
            // create filter
            ContrastStretch filter = new ContrastStretch();
            // process image
            filter.ApplyInPlace(image);
        }
        public static Bitmap HistogramEqualization(Bitmap image)
        {
            // create filter
            HistogramEqualization filter = new HistogramEqualization();
            // process image
            return filter.Apply(image);
        }

        public static void GaussianSharpen(ref Bitmap image, float sigma, int kernel)
        {
            // create filter with kernel size equal to 11
            // and Gaussia sigma value equal to 4.0
            GaussianSharpen filter = new GaussianSharpen(sigma, kernel);
            filter.ApplyInPlace(image);
        }

        public static void Sharpen(ref Bitmap image)
        {
            // create filter
            Sharpen filter = new Sharpen();
            // apply the filter
            filter.ApplyInPlace(image);
        }

        public static void LevelTresholdInPlace(ref Bitmap image, int whiteLevel, int blackLevel)
        {
            var filter = new LevelsLinear
            {
                // set ranges
                InRed = new IntRange(blackLevel, whiteLevel),
                InGreen = new IntRange(blackLevel, whiteLevel),
                InBlue = new IntRange(blackLevel, whiteLevel)
            };
            // apply the filter
            filter.ApplyInPlace(image);
        }

        public static Bitmap Crop(Bitmap image, Rectangle rectangle)
        {
            var filter = new Crop(rectangle);
            // apply the filter
            return filter.Apply(image);
        }

        public static List<Bitmap> VerticalSplit(Bitmap image)
        {
            if (image.Width <= image.Height)
                return new List<Bitmap> { image };

            var leftImageRectangle = new Rectangle(0, 0, image.Width / 2, image.Height);
            var rightImageRectangle = new Rectangle(image.Width / 2, 0, image.Width / 2, image.Height);

            return new List<Bitmap>
            {
                new Crop(leftImageRectangle).Apply(image),
                new Crop(rightImageRectangle).Apply(image)
            };
        }

        public static Bitmap ConvertToFormat(this System.Drawing.Image image, PixelFormat format)
        {
            Bitmap copy = new Bitmap(image.Width, image.Height, format);
            using (Graphics gr = Graphics.FromImage(copy))
            {
                gr.DrawImage(image, new Rectangle(0, 0, copy.Width, copy.Height));
            }
            return copy;
        }

        //Soften trame patterns
        public static void GaussianBlur(ref Bitmap image, double sigma=2.0, int size=7)
        {
            GaussianBlur filter = new GaussianBlur(sigma, size);
            filter.ApplyInPlace(image);
        }

        //noise reduction
        public static void Medianfilter(ref Bitmap image)
        {
            Median filter = new Median();
            filter.ApplyInPlace(image);
        }
    }
}
