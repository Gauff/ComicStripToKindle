using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComicStripToKindle.UI
{
    public class HistogramGenerator
    {
        public static void GenerateLogarithmicHistogram(PictureBox inputPictureBox, PictureBox outputPictureBox)
        {
            if (inputPictureBox.Image == null)
            {
                throw new ArgumentException("Input PictureBox does not contain an image.");
            }

            Bitmap inputBitmap = new Bitmap(inputPictureBox.Image);

            // Calculate histogram
            int[] histogram = new int[256];
            for (int y = 0; y < inputBitmap.Height; y++)
            {
                for (int x = 0; x < inputBitmap.Width; x++)
                {
                    Color pixelColor = inputBitmap.GetPixel(x, y);
                    int brightness = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3.0);
                    histogram[brightness]++;
                }
            }

            // Normalize and apply logarithmic scale
            double max = histogram[0];
            foreach (int value in histogram)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            // Apply logarithmic transformation
            double logBase = 10;
            double logMax = Math.Log(max, logBase);

            // Create histogram image
            Bitmap histogramBitmap = new Bitmap(256, 100);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)((Math.Log(histogram[i] == 0 ? 1 : histogram[i], logBase) / logMax) * histogramBitmap.Height);
                    g.DrawLine(Pens.Black, new Point(i, histogramBitmap.Height), new Point(i, histogramBitmap.Height - height));
                }
            }

            // Set the histogram image to the output PictureBox
            outputPictureBox.Image = histogramBitmap;
        }

        public static void GenerateSquareRootHistogram(PictureBox inputPictureBox, PictureBox outputPictureBox)
        {
            if (inputPictureBox.Image == null)
            {
                throw new ArgumentException("Input PictureBox does not contain an image.");
            }

            Bitmap inputBitmap = new Bitmap(inputPictureBox.Image);

            // Calculate histogram
            int[] histogram = new int[256];
            for (int y = 0; y < inputBitmap.Height; y++)
            {
                for (int x = 0; x < inputBitmap.Width; x++)
                {
                    Color pixelColor = inputBitmap.GetPixel(x, y);
                    int brightness = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3.0);
                    histogram[brightness]++;
                }
            }

            // Normalize and apply square root scale
            int max = 0;
            foreach (int value in histogram)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            // Apply square root transformation
            double maxSqrt = Math.Sqrt(max);

            // Create histogram image
            Bitmap histogramBitmap = new Bitmap(256, 100);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)((Math.Sqrt(histogram[i]) / maxSqrt) * histogramBitmap.Height);
                    g.DrawLine(Pens.Black, new Point(i, histogramBitmap.Height), new Point(i, histogramBitmap.Height - height));
                }
            }

            // Set the histogram image to the output PictureBox
            outputPictureBox.Image = histogramBitmap;
        }

        public static void GenerateInverseHistogram(PictureBox inputPictureBox, PictureBox outputPictureBox, Color backgroundColor)
        {
            if (inputPictureBox.Image == null)
            {
                throw new ArgumentException("Input PictureBox does not contain an image.");
            }

            Bitmap inputBitmap = new Bitmap(inputPictureBox.Image);

            // Calculate histogram
            int[] histogram = new int[256];
            for (int y = 0; y < inputBitmap.Height; y++)
            {
                for (int x = 0; x < inputBitmap.Width; x++)
                {
                    Color pixelColor = inputBitmap.GetPixel(x, y);
                    int brightness = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3.0);
                    histogram[brightness]++;
                }
            }

            // Normalize histogram for display
            int max = 0;
            foreach (int value in histogram)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            // Create histogram image
            Bitmap histogramBitmap = new Bitmap(256, 100);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(backgroundColor); // Set background color
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)((histogram[i] / (float)max) * histogramBitmap.Height);
                    g.DrawLine(Pens.White, new Point(i, histogramBitmap.Height), new Point(i, histogramBitmap.Height - height)); // Draw histogram in white
                }
            }

            // Set the histogram image to the output PictureBox
            outputPictureBox.Image = histogramBitmap;
        }
    }
}