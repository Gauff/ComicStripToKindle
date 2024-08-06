using AForge.Imaging;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.Profiles;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ComicStripToKindle.PanelExtraction
{
    class CropWhiteBordersBitmapPanelExtraction : BitmapPanelExtraction
    {
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

                var rectangle = GetByLineAndColumnScanQuadrilateralBlobs(invertedImage);

                return new List<Blob> { new Blob(0, rectangle) };
            }
        }


        static public Rectangle GetByLineAndColumnScanQuadrilateralBlobs(Bitmap bitmap)
        {
            var blobsLineGroups = ByWhiteLinesDetectionBitmapPanelExtraction.AreEmptyLines2(bitmap)
                .GroupAdjacent(y => y.Value)
                .Where(y => !y.Key)
                .ToList();

            int sizeTresholdPercentage = 2;

            var topY = 0;
            var bottomY = 0;

            var firstNotEmptyLineGroup = blobsLineGroups.FirstOrDefault();
            if (null != firstNotEmptyLineGroup)
                topY = firstNotEmptyLineGroup.ToList().Min(x => x.Key);

            var lastNotEmptyLineGroup = blobsLineGroups.LastOrDefault();
            if (null != lastNotEmptyLineGroup)
                bottomY = lastNotEmptyLineGroup.ToList().Max(x => x.Key);

            var yGroupSizeThreshold = (bottomY - topY) / 100 * sizeTresholdPercentage; 

            var blobColumnGroups = ByWhiteLinesDetectionBitmapPanelExtraction.AreEmptyColumns2(bitmap)
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

            var xGroupSizeThreshold = (maxX - minX) /100 * sizeTresholdPercentage;

            //Filter out groups smaller than 2% height and smaller than 2% wide
            blobColumnGroups = blobColumnGroups.Where(group => group.Count() > xGroupSizeThreshold).ToList();
            blobsLineGroups = blobsLineGroups.Where(group => group.Count() > yGroupSizeThreshold).ToList();

            var firstNotEmptyLineGroupAfterFiltering = blobsLineGroups.FirstOrDefault();
            if (null != firstNotEmptyLineGroupAfterFiltering)
                topY = firstNotEmptyLineGroupAfterFiltering.ToList().Min(x => x.Key);

            var lastNotEmptyLineGroupAfterFiltering = blobsLineGroups.LastOrDefault();
            if (null != lastNotEmptyLineGroupAfterFiltering)
                bottomY = lastNotEmptyLineGroupAfterFiltering.ToList().Max(x => x.Key);

            var firstNotEmptyColumnGroupAfterFiltering = blobColumnGroups.FirstOrDefault();
            if (null != firstNotEmptyColumnGroupAfterFiltering)
                minX = firstNotEmptyColumnGroupAfterFiltering.ToList().Min(x => x.Key);

            var lastNotEmptyColumnGroupAfterFiltering = blobColumnGroups.LastOrDefault();
            if (null != lastNotEmptyColumnGroupAfterFiltering)
                maxX = lastNotEmptyColumnGroupAfterFiltering.ToList().Max(x => x.Key);

            return new Rectangle(minX, topY, maxX - minX, bottomY - topY);
        }
    }
}
