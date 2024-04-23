using ComicStripToKindle.Extensions;
using ComicStripToKindle.Pdf;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ComicStripToKindle
{
    class GammaScale
    {
        public static string GenerateGammaLinearGreyGradientPdfPage(ElectronicReaderProfile profile)
        {
            var tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();
            var grayScaleJpgFilePath = Path.Combine(tempDirectory, "GrayScale.jpg");
            var grayScalePdfFilePath = Path.Combine(tempDirectory, "GrayScale32WithGammaAdjustments.pdf");

            var gradientImage = GenerateGammaLinearGrayGradientPage(profile);

            ImageFilters.Rotate(gradientImage, 90)
                .SaveToJpegFile(grayScaleJpgFilePath, 100);

            new PdfWriter().WritePdf(new List<string> { grayScaleJpgFilePath }, grayScalePdfFilePath);

            return grayScalePdfFilePath;
        }

        static Bitmap GenerateGammaLinearGrayGradientPage(ElectronicReaderProfile profile)
        {
            var minGamma = 0f;
            var maxGamma = 2.5f;
            var gammaInterval = 0.15f;

            var page = new Bitmap(profile.VerticalResolution, profile.HorizontalResolution, PixelFormat.Format24bppRgb);

            var gradientsCount = 2 + ((maxGamma - minGamma) / gammaInterval);

            var scaleWidth = profile.VerticalResolution / (gradientsCount + 1);
            var scaleHeight = profile.HorizontalResolution;

            var gradient = GenerateLinear32GrayGradient((int)scaleWidth, scaleHeight);

            var x = 0.0f;
            var gamma = minGamma;

            var g = Graphics.FromImage(page);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            for (var i = 0; i < gradientsCount; i++)
            {
                if (i == 0)
                {
                    g.DrawImage(gradient, new PointF(x, 0));

                    using (var font = new Font("Corbel", 15, FontStyle.Bold))
                    {
                        g.DrawString("---", font, Brushes.Black, x, 15);
                    }
                }
                else
                {
                    g.DrawImage(ImageFilters.GammaCorrection(gradient, gamma), new PointF(x, 0));

                    using (var font = new Font("Corbel", 15, FontStyle.Bold))
                    {
                        g.DrawString(gamma.ToString("0.00"), font, Brushes.Black, x, 15);
                    }

                    gamma += gammaInterval;
                }

                x += scaleWidth;

            }

            return page;
        }

        static Bitmap GenerateLinearGrayGradient(float width, float height)
        {
            using (var linGrBrush =
                new LinearGradientBrush(
                    new RectangleF(0, 0, width, height),
                    Color.FromKnownColor(KnownColor.White),
                    Color.FromKnownColor(KnownColor.Black),
                    LinearGradientMode.Vertical))
            {
                var bmp = new Bitmap((int)width, (int)height, PixelFormat.Format24bppRgb);
                using (var gfx = Graphics.FromImage(bmp))
                {
                    gfx.FillRectangle(linGrBrush, 0, 0, width, height);
                }
                return bmp;
            }
        }
        static Bitmap GenerateLinear32GrayGradient(float width, float height)
        {
            using (var linGrBrush =
                new LinearGradientBrush(
                    new RectangleF(0, 0, width, height),
                    Color.FromKnownColor(KnownColor.White),
                    Color.FromKnownColor(KnownColor.Black),
                    LinearGradientMode.Vertical))
            {
                const int gradientCount = 32;
                float gradientInterval = 256 / gradientCount;
                var gradientHeightInterval = height / gradientCount;


                var colorLevel = 255f;
                var fontLevel = 0.0f;
                var yFrom = 0.0f;
                var yTo = yFrom + gradientHeightInterval;
                var bmp = new Bitmap((int)width, (int)height, PixelFormat.Format24bppRgb);
                using (var gfx = Graphics.FromImage(bmp))
                {
                    gfx.SmoothingMode = SmoothingMode.AntiAlias;
                    gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    var iGradient = 0;
                    while (iGradient <= gradientCount)
                    {
                        using (var brush = new SolidBrush(Color.FromArgb((int)colorLevel, (int)colorLevel, (int)colorLevel)))
                        {
                            gfx.FillRectangle(brush, new RectangleF(0, yFrom, width, yTo));

                            if (iGradient % 2 == 0)
                            {
                                fontLevel = colorLevel <= 256 / 2 ? 255 : 0;

                                using (var font = new Font("Corbel", 12, FontStyle.Bold))
                                {
                                    Brush fontBrushColor = new SolidBrush(Color.FromArgb((int)fontLevel, (int)fontLevel, (int)fontLevel));

                                    gfx.DrawString(Convert.ToInt32(colorLevel).ToString(), font, fontBrushColor, 0, yFrom);
                                }
                            }
                        }

                        colorLevel -= gradientInterval;
                        if (colorLevel < 0) colorLevel = 0;

                        fontLevel += gradientInterval;
                        if (fontLevel > 255) fontLevel = 255;

                        yFrom = yTo;
                        yTo += gradientHeightInterval;
                        iGradient++;
                    }
                }
                return bmp;
            }
        }
    }
}
