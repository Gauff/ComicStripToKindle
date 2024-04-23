using AForge.Imaging;
using ComicStripToKindle.Profiles;
using System.Collections.Generic;
using System.Drawing;

namespace ComicStripToKindle.PanelExtraction
{
    public interface IBitmapPanelExtraction
    {
        List<Bitmap> ExtractPanelsFromComicImagePage(
            Bitmap image,
            ComicConversionProfile profile);

        List<Blob> ExtractBlobPanelsFromComicImagePage(
            Bitmap image,
            ComicConversionProfile profile);
    }
}