using System.Drawing;
using System.Windows.Forms;

namespace ComicStripToKindle.UI
{
    public static class PictureBoxSizeExtensions
    {
        public static void SetPictureBoxSizeInCm(this PictureBox pictureBox, double widthCm, double heightCm)
        {
            // 1 inch = 2.54 cm
            double widthInches = widthCm / 2.54;
            double heightInches = heightCm / 2.54;

            // Get the graphics object to determine the screen DPI
            using (Graphics g = Graphics.FromHwnd(pictureBox.Handle))
            {
                float dpiX = g.DpiX;
                float dpiY = g.DpiY;

                // Convert inches to pixels
                int widthPixels = (int)(widthInches * dpiX);
                int heightPixels = (int)(heightInches * dpiY);

                // Set the PictureBox size
                pictureBox.Width = widthPixels;
                pictureBox.Height = heightPixels;
            }
        }
    }
}
