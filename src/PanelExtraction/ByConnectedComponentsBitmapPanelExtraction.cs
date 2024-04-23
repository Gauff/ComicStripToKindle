using AForge;
using AForge.Imaging;
using AForge.Math.Geometry;
using ComicStripToKindle.PanelOrdering;
using ComicStripToKindle.Profiles;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ComicStripToKindle.PanelExtraction
{
    class ByConnectedComponentsBitmapPanelExtraction : BitmapPanelExtraction
    {
        public override List<Bitmap> ExtractPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile)
        {
            var blobs = ExtractBlobPanelsFromComicImagePage(image, profile);

            return ExtractPanelsFromComicImagePage(image, blobs, profile.IncludePageIfNoPanelDetected).ToList();
        }

        public override List<Blob> ExtractBlobPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile)
        {
            using (var invertedImage = ImageFilters.ProcessImageForPanelBlobExtraction(
                image,
                profile.WhiteBackgroundTreshold,
                profile.BlackBackground))
            {
                var panelBlobs = GetConnectedComponentQuadrilateralBlobs(invertedImage);

                var panelOrdering = new PanelOrderingWithBlokkers();
                var blobs = panelOrdering.OrderPanels(panelBlobs, profile.PanelReadingDirection, 20);

                return blobs.ToList();
            }
        }
        private static List<Blob> GetConnectedComponentQuadrilateralBlobs(Bitmap image)
        {
            var blobCounter = new BlobCounter
            {
                FilterBlobs = true,
                MinWidth = 50,
                MinHeight = 50,
                ObjectsOrder = ObjectsOrder.YX,
            };
            blobCounter.ProcessImage(image);

            var blobs = blobCounter.GetObjectsInformation();

            var quadrilateralBlobs = new List<Blob>();

            //Bitmap EditableImg = new Bitmap(image);
            //var imageFromFile = AForge.Imaging.Image.FromFile("03.jpg");

            //Graphics g = Graphics.FromImage(EditableImg);
            //Pen redPen = new Pen(Color.Red, 5);
            //Pen greenPen = new Pen(Color.Lime, 5);

            foreach (var blob in blobs)
            {
                var shapeChecker = new SimpleShapeChecker();

                var edgePoints = blobCounter.GetBlobsEdgePoints(blob);


                if (!shapeChecker.IsConvexPolygon(edgePoints, out List<IntPoint> corners))
                    continue;

                var subType = shapeChecker.CheckPolygonSubType(corners);

                //Pen pen;

                if (subType == PolygonSubType.Rectangle || subType == PolygonSubType.Square)
                    quadrilateralBlobs.Add(blob);
            }

            return quadrilateralBlobs;
        }
    }
}
