using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ComicStripToKindle.UI
{
    public static class ImageUtilities
    {
        public static long GetImageSizeInBytes(Image image, ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                // Save the image to the memory stream with the specified format
                image.Save(ms, format);
                // Return the length of the memory stream which represents the size in bytes
                return ms.Length;
            }
        }
    }
}
