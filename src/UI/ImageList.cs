using System.Drawing;
using System.Windows.Forms;

namespace ComicStripToKindle.UI
{
    public static class ImageLists
    {
        public enum ImageStates : int
        {
            None = 0,
            Processing = 1,
            Done = 2,
            Warning = 3,
            Error = 4,
            DoneWarning = 5
        }

        public static ImageList BuildImageList()
        {
            var imageList = new ImageList();

            imageList.Images.Add("Transparent", DrawCircleIcon(Color.Transparent));
            imageList.Images.Add("Blue", DrawCircleIcon(Color.Blue));
            imageList.Images.Add("Green", DrawCircleIcon(Color.Green));
            imageList.Images.Add("Orange", DrawCircleIcon(Color.Orange));
            imageList.Images.Add("Red", DrawCircleIcon(Color.Red));
            imageList.Images.Add("DoneWarning", DrawCircleIcon(Color.YellowGreen));

            return imageList;
        }


        public static Icon DrawCircleIcon(Color color)
        {
            var canvas = new Bitmap(16, 16);

            using (var gfx = Graphics.FromImage(canvas))
            {
                var p = new Pen(new SolidBrush(Color.Transparent), 10);
                var rt = new Rectangle(0, 0, 16, 16);
                gfx.DrawEllipse(p, rt);

                gfx.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                gfx.FillEllipse(new SolidBrush(color), 0, 0, 16, 16);

                return Icon.FromHandle(canvas.GetHicon());
            }

        }
    }
}
