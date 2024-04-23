using System.Drawing;

namespace ComicStripToKindle.Extensions
{
    public static class RectangleExtensions
    {
        public static Rectangle AddTolerance(this Rectangle rectangle, int tolerance)
        {
            return new Rectangle(
                rectangle.X - (tolerance / 2),
                rectangle.Y - (tolerance / 2),
                rectangle.Width + (tolerance),
                rectangle.Height + (tolerance));

        }
        public static bool AreOverlapping(this Rectangle r1, Rectangle r2, int tolerance)
        {
            return IsInTolerance(r1.X, r2.X, tolerance)
                && IsInTolerance(r1.Y, r2.Y, tolerance)
                && IsInTolerance(r1.Height, r2.Height, tolerance)
                && IsInTolerance(r1.Width, r2.Width, tolerance);
        }

        static bool IsInTolerance(int v1, int v2, int tolerance)
        {
            var inTolerance = false;
            if (v1 >= v2)
            {
                if (v1 - v2 <= tolerance)
                    inTolerance = true;
            }
            else
            {
                if (v2 - v1 <= tolerance)
                    inTolerance = true;
            }
            return inTolerance;
        }

    }
}
