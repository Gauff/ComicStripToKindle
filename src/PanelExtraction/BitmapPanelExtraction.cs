using AForge.Imaging;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace ComicStripToKindle.PanelExtraction
{
    public abstract class BitmapPanelExtraction : IBitmapPanelExtraction
    {
        public abstract List<Bitmap> ExtractPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile);
        public abstract List<Blob> ExtractBlobPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile);

        protected static List<Bitmap> ExtractPanelsFromComicImagePage(Bitmap originalImage, List<Blob> panels, bool includePageIfNoPanelHasBeenFound)
        {
            var images = new List<Bitmap>();

            foreach (var panel in panels)
            {
                if (panel.Rectangle.IsEmpty)
                    continue;

                if (panel.Rectangle.Height == 0 || panel.Rectangle.Width == 0)
                    continue;

                // create filter
                //var filter = new Crop(panel.Rectangle); OLD way lead to png black images

                try
                {
                    // Create a new bitmap to hold the cropped image
                    using (Bitmap croppedImage = new Bitmap(panel.Rectangle.Width, panel.Rectangle.Height))
                    {
                        // Use Graphics to draw the cropped portion onto the new bitmap
                        using (Graphics g = Graphics.FromImage(croppedImage))
                        {
                            g.DrawImage(
                                originalImage,
                                new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                                panel.Rectangle,
                                GraphicsUnit.Pixel);
                        }

                        Bitmap croppedFormatedImage = ImageFilters.ConvertToFormat(croppedImage, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                        images.Add(croppedFormatedImage);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }

            if (includePageIfNoPanelHasBeenFound && (panels.Count == 0 || images.Count == 0))
                images.Add(originalImage);

            return images;
        }
    }
}
