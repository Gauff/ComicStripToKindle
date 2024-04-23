using AForge.Imaging;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace ComicStripToKindle.PanelExtraction
{
    class ByWhiteLinesDetectionBitmapPanelExtraction : BitmapPanelExtraction
    {
        private static Color EmptyPixelColor => Color.FromArgb(255, 0, 0, 0);

        public override List<Bitmap> ExtractPanelsFromComicImagePage(
            Bitmap image,
            ComicConversionProfile profile)
        {
            var blobs = ExtractBlobPanelsFromComicImagePage(image, profile);

            return ExtractPanelsFromComicImagePage(image, blobs, profile.IncludePageIfNoPanelDetected);
        }

        public override List<Blob> ExtractBlobPanelsFromComicImagePage(
            Bitmap image,
            ComicConversionProfile profile)
        {
            using (var invertedImage = ImageFilters.ProcessImageForPanelBlobExtraction(
                image,
                profile.WhiteBackgroundTreshold,
                profile.BlackBackground))
            {
                //invertedImage.SaveToJpegFile(@"d:\inverted.jpg", 100);

                var blobs = GetByLineAndColumnScanQuadrilateralBlobsRecursive(
                    invertedImage,
                    profile.MinimumPanelSizeWidthFraction,
                    profile.MinimumPanelSizeHeightFraction,
                    profile.PanelReadingDirection,
                    profile.HorizontalLinesOnly);

                return blobs.ToList();
            }
        }

        static List<Blob> GetByLineAndColumnScanQuadrilateralBlobsRecursive(
            Bitmap bitmap,
            int minimumPanelSizeWidthFraction,
            int minimumPanelSizeHeightFraction,
            PanelReadingDirection panelReadingDirection,
            bool horizontalOnly)
        {
            var blobRectangles = new List<Rectangle>();

            GetByLineAndColumnScanQuadrilateralBlobsRecursive(
                bitmap,
                bitmap.Width / minimumPanelSizeWidthFraction,
                bitmap.Height / minimumPanelSizeHeightFraction,
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ref blobRectangles,
                panelReadingDirection,
                horizontalOnly);

            var blobId = 0;
            return blobRectangles
                .Select(x => new Blob(blobId++, x))
                .ToList();
        }

        static void GetByLineAndColumnScanQuadrilateralBlobsRecursive(
            Bitmap bitmap,
            int minimumPixelsWidth,
            int minimumPixelsHeight,
            Rectangle selectionOutOfOriginalBitmap,
            ref List<Rectangle> blobs,
            PanelReadingDirection panelReadingDirection,
            bool horizontalOnly)
        {
            // Debug.WriteLine($"                                      X:{selectionOutOfOriginalBitmap.X} Y:{selectionOutOfOriginalBitmap.Y} Width:{selectionOutOfOriginalBitmap.Width} Height:{selectionOutOfOriginalBitmap.Height}");

            if (bitmap.Height < minimumPixelsHeight)
                return;

            if (horizontalOnly)
            {
                var blobsLineGroups = AreEmptyLines2(bitmap)
                    .GroupAdjacent(y => y.Value)
                    .Where(y => !y.Key)
                    .Where(y => y.Count() > minimumPixelsHeight)
                    .ToList();

                foreach (var blobsLineGroup in blobsLineGroups)
                {
                    try
                    {
                        var yTop = blobsLineGroup.First().Key;
                        var yBottom = blobsLineGroup.Last().Key;
                        var height = yBottom - yTop;

                        if (height == 0)
                            continue;


                        var blobColumnGroups = AreEmptyColumns2(bitmap)
                            .GroupAdjacent(x => x.Value)
                            .Where(x => !x.Key)
                            .ToList();

                        var minX = 0;
                        var maxX = 0;

                        var firstNotEmptyColumnGroup = blobColumnGroups.FirstOrDefault();
                        if (null != firstNotEmptyColumnGroup)
                            minX = firstNotEmptyColumnGroup.ToList().Min(x => x.Key);

                        var lastNotEmptyColumnGroup = blobColumnGroups.LastOrDefault();
                        if (null != lastNotEmptyColumnGroup)
                            maxX = lastNotEmptyColumnGroup.ToList().Max(x => x.Key);



                        var blobsLineAreaRectangle = new Rectangle(minX, yTop, maxX - minX, height);

                        blobs.Add(blobsLineAreaRectangle);
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
            else
            {
                var blobsLineGroups = AreEmptyLines2(bitmap)
                    .GroupAdjacent(y => y.Value)
                    .Where(y => !y.Key)
                    .Where(y => y.Count() > minimumPixelsHeight)
                    .ToList();

                foreach (var blobsLineGroup in blobsLineGroups)
                {
                    try
                    {
                        var yTop = blobsLineGroup.First().Key;
                        var yBottom = blobsLineGroup.Last().Key;
                        var height = yBottom - yTop;

                        if (height == 0)
                            continue;

                        var blobsLineAreaRectangle = new Rectangle(0, yTop, bitmap.Width, height);

                        using (var blobsLineAreaRectangleBitmap = ImageFilters.Crop(bitmap, blobsLineAreaRectangle))
                        {
                            var blobColumnGroups = AreEmptyColumns2(blobsLineAreaRectangleBitmap)
                                .GroupAdjacent(x => x.Value)
                                .Where(x => !x.Key)
                                .Where(x => x.Count() > minimumPixelsWidth)
                                .ToList();

                            if (panelReadingDirection.HasFlag(PanelReadingDirection.RightToLeft))
                                blobColumnGroups.Reverse();

                            if (blobsLineGroups.Count == 1 && blobColumnGroups.Count == 1)
                            {
                                AddBlob(ref blobs, selectionOutOfOriginalBitmap, yTop, height, blobColumnGroups[0]);
                                return;
                            }

                            foreach (var blobColumnGroup in blobColumnGroups)
                                GetColumnBlobs(
                                    bitmap,
                                    minimumPixelsWidth,
                                    minimumPixelsHeight,
                                    ref selectionOutOfOriginalBitmap,
                                    ref blobs,
                                    yTop,
                                    height,
                                    blobColumnGroup,
                                    panelReadingDirection,
                                    horizontalOnly);
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine(e.ToString());
                    }
                }
            }

            Debug.WriteLine("Exit");
        }


        static void GetByLineAndColumnScanQuadrilateralBlobsRecursiveOld(
            Bitmap bitmap,
            int minimumPixelsWidth,
            int minimumPixelsHeight,
            Rectangle selectionOutOfOriginalBitmap,
            ref List<Rectangle> blobs,
            PanelReadingDirection panelReadingDirection,
            bool horizontalOnly)
        {
            //Debug.WriteLine($"                                      X:{selectionOutOfOriginalBitmap.X} Y:{selectionOutOfOriginalBitmap.Y} Width:{selectionOutOfOriginalBitmap.Width} Height:{selectionOutOfOriginalBitmap.Height}");

            if (bitmap.Width < minimumPixelsWidth || bitmap.Height < minimumPixelsHeight)
                return;

            var blobsLineGroups = AreEmptyLines2(bitmap)
                .GroupAdjacent(y => y.Value)
                .Where(y => !y.Key)
                .Where(x => x.Count() > minimumPixelsHeight)
                .ToList();

            foreach (var blobsLineGroup in blobsLineGroups)
            {
                try
                {
                    var yTop = blobsLineGroup.First().Key;
                    var yBottom = blobsLineGroup.Last().Key;
                    var height = yBottom - yTop;

                    if (height == 0)
                        continue;

                    var blobsLineAreaRectangle = new Rectangle(0, yTop, bitmap.Width, height);

                    using (var blobsLineAreaRectangleBitmap = ImageFilters.Crop(bitmap, blobsLineAreaRectangle))
                    {
                        var blobColumnGroups = AreEmptyColumns2(blobsLineAreaRectangleBitmap)
                            .GroupAdjacent(x => x.Value)
                            .Where(x => !x.Key)
                            .Where(x => x.Count() > minimumPixelsHeight)
                            .ToList();

                        if (panelReadingDirection.HasFlag(PanelReadingDirection.RightToLeft))
                            blobColumnGroups.Reverse();

                        if (blobsLineGroups.Count == 1 && blobColumnGroups.Count == 1)
                        {
                            AddBlob(ref blobs, selectionOutOfOriginalBitmap, yTop, height, blobColumnGroups[0]);
                            return;
                        }

                        foreach (var blobColumnGroup in blobColumnGroups)
                            GetColumnBlobs(
                                bitmap,
                                minimumPixelsWidth,
                                minimumPixelsHeight,
                                ref selectionOutOfOriginalBitmap,
                                ref blobs,
                                yTop,
                                height,
                                blobColumnGroup,
                                panelReadingDirection,
                                horizontalOnly);
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                    //Debug.WriteLine($"x:{blobsLineAreaRectangle.X} y:{blobsLineAreaRectangle.Y} width:{blobsLineAreaRectangle.Width} height:{blobsLineAreaRectangle.Height}");
                }
            }
            Debug.WriteLine("Exit");
        }

        static void AddBlob(
            ref List<Rectangle> blobs,
            Rectangle selectionOutOfOriginalBitmap,
            int yTop,
            int height,
            IGrouping<bool, KeyValuePair<int, bool>> blobColumnGroup)
        {
            var xStart = blobColumnGroup.First().Key;
            var xEnd = blobColumnGroup.Last().Key;

            var panelRectangle = new Rectangle(
                selectionOutOfOriginalBitmap.X + xStart,
                selectionOutOfOriginalBitmap.Y + yTop,
                xEnd - xStart,
                height);

            blobs.Add(panelRectangle);

            //Debug.WriteLine($" * Added: X:{panelRectangle.X} Y:{panelRectangle.Y} Width:{panelRectangle.Width} Height:{panelRectangle.Height}");
        }

        static void GetColumnBlobs(
            Bitmap bitmap,
            int minimumPixelsWidth,
            int minimumPixelsHeight,
            ref Rectangle selectionOutOfOriginalBitmap,
            ref List<Rectangle> blobs,
            int yTop,
            int height,
            IGrouping<bool, KeyValuePair<int, bool>> blobColumnGroup,
            PanelReadingDirection panelReadingDirection,
            bool horizontalOnly)
        {
            var xStart = blobColumnGroup.First().Key;
            var xEnd = blobColumnGroup.Last().Key;

            var localBlobAreaRectangle = new Rectangle(
                xStart,
                yTop,
                xEnd - xStart,
                height);

            var blobsColumnGroupBitmap = ImageFilters.Crop(bitmap, localBlobAreaRectangle);

            var globalAreaRectangle = new Rectangle(
                selectionOutOfOriginalBitmap.X + xStart,
                selectionOutOfOriginalBitmap.Y + yTop,
                xEnd - xStart,
                height);

            GetByLineAndColumnScanQuadrilateralBlobsRecursive(
                blobsColumnGroupBitmap,
                minimumPixelsWidth,
                minimumPixelsHeight,
                globalAreaRectangle,
                ref blobs,
                panelReadingDirection,
                horizontalOnly);
        }

        /// <summary>
        /// analyzes a bitmap image to determine if each row (line) is entirely empty, 
        /// meaning all pixels in that row have the same color as specified by EmptyPixelColor. 
        /// It returns a dictionary where the key is the row index and the value indicates whether the row is empty or not.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Dictionary<int, bool> AreEmptyLines2(Bitmap bitmap)
        {
            var areEmptyLines = new Dictionary<int, bool>();

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                // Get the address of the first line.
                var ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                var bytes = bmpData.Stride * bitmap.Height;
                var rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                Marshal.Copy(ptr, rgbValues, 0, bytes);

                var stride = bmpData.Stride;

                for (var y = 0; y < bmpData.Height; y++)
                {
                    var lineEmptyPixelsCount = 0;

                    for (var x = 0; x < bmpData.Width; x++)
                    {
                        var index = (y * stride) + (x * 3);
                        var b = rgbValues[index];
                        var g = rgbValues[index + 1];
                        var r = rgbValues[index + 2];

                        if (r == EmptyPixelColor.R && g == EmptyPixelColor.G && b == EmptyPixelColor.B)
                            lineEmptyPixelsCount++;
                    }

                    areEmptyLines.Add(y, lineEmptyPixelsCount == bitmap.Width);
                }
            }
            finally
            {
                bitmap.UnlockBits(bmpData);
            }

            return areEmptyLines;
        }

        /// <summary>
        /// This method AreEmptyColumns2 analyzes a bitmap image to determine if each column is entirely empty, 
        /// meaning all pixels in that column have the same color as specified by EmptyPixelColor. 
        /// It returns a dictionary where the key is the column index and the value indicates whether the column is empty or not.
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        public static Dictionary<int, bool> AreEmptyColumns2(Bitmap bitmap)
        {
            var areEmptyColumns = new Dictionary<int, bool>();

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                // Get the address of the first line.
                var ptr = bmpData.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                var bytes = bmpData.Stride * bitmap.Height;
                var rgbValues = new byte[bytes];

                // Copy the RGB values into the array.
                Marshal.Copy(ptr, rgbValues, 0, bytes);

                var stride = bmpData.Stride;

                for (var x = 0; x < bmpData.Width; x++)
                {
                    var columnEmptyPixelsCount = 0;

                    for (var y = 0; y < bmpData.Height; y++)
                    {
                        var index = (y * stride) + (x * 3);
                        var b = rgbValues[index];
                        var g = rgbValues[index + 1];
                        var r = rgbValues[index + 2];

                        if (r == EmptyPixelColor.R && g == EmptyPixelColor.G && b == EmptyPixelColor.B)
                            columnEmptyPixelsCount++;
                    }

                    areEmptyColumns.Add(x, columnEmptyPixelsCount == bitmap.Height);
                }
            }
            finally
            {
                bitmap.UnlockBits(bmpData);
            }

            return areEmptyColumns;
        }
    }
}