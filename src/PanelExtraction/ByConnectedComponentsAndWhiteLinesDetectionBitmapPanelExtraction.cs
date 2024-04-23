using AForge.Imaging;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.PanelOrdering;
using ComicStripToKindle.Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
namespace ComicStripToKindle.PanelExtraction
{
    class ByConnectedComponentsAndWhiteLinesDetectionBitmapPanelExtraction : BitmapPanelExtraction
    {
        public override List<Blob> ExtractBlobPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile)
        {
            List<Blob> blobsByConnectedComponents;
            List<Blob> blobsByWhiteLinesDetection;

            using (var bitmap = new Bitmap(image))
            {
                blobsByConnectedComponents = BitmapPanelExtractionFactory
                    .Build(PanelDetectionAlgorithm.ByConnectedComponents)
                    .ExtractBlobPanelsFromComicImagePage(bitmap, profile);

                Debug.WriteLine($"By Connected components: {blobsByConnectedComponents.Count}");
                foreach (var blob in blobsByConnectedComponents)
                    Debug.WriteLine($"X:{blob.Rectangle.X} Y:{blob.Rectangle.Y} W:{blob.Rectangle.Width} H:{blob.Rectangle.Height}");

                blobsByWhiteLinesDetection = BitmapPanelExtractionFactory
                    .Build(PanelDetectionAlgorithm.ByWhiteLinesDetection)
                    .ExtractBlobPanelsFromComicImagePage(bitmap, profile);

                Debug.WriteLine($"By white lines detection: {blobsByWhiteLinesDetection.Count}");
                foreach (var blob in blobsByWhiteLinesDetection)
                    Debug.WriteLine($"X:{blob.Rectangle.X} Y:{blob.Rectangle.Y} W:{blob.Rectangle.Width} H:{blob.Rectangle.Height}");
            }

            var blobs = new List<Blob>();
            blobs.AddRange(blobsByWhiteLinesDetection);
            blobs.AddRange(blobsByConnectedComponents);

            if (blobs.Count == 0)
                return new List<Blob>();

            var confirmedBlobs = new List<Blob>();
            var groups = new Dictionary<Blob, List<Blob>> { { blobs[0], new List<Blob> { blobs[0] } } };

            var tolerance = 15;
            foreach (var blob in blobs.Skip(1))
            {
                //Is blob in tolerence of one blob group?
                // Yes -> add it to the group
                // No  -> create new group

                var groupKey = groups.Keys.FirstOrDefault(key => key.Rectangle.AreOverlapping(blob.Rectangle, tolerance));

                if (null == groupKey)
                    groups.Add(blob, new List<Blob> { blob });
                else
                {
                    var groupBlobs = groups[groupKey];
                    groupBlobs.Add(blob);
                    groups[groupKey] = groupBlobs;
                }
            }

            Debug.WriteLine($"Ordered blobs: {groups.Keys.Count} groups");
            foreach (var blobKey in groups.Keys)
            {
                Debug.WriteLine($"- Key: X:{blobKey.Rectangle.X} Y:{blobKey.Rectangle.Y} W:{blobKey.Rectangle.Width} H:{blobKey.Rectangle.Height}");

                foreach (var blob in groups[blobKey])
                {
                    Debug.WriteLine($"  - X:{blob.Rectangle.X} Y:{blob.Rectangle.Y} W:{blob.Rectangle.Width} H:{blob.Rectangle.Height}");
                }

            }

            //Now we have either 
            //- groups containing two blobs: they are confirmed by both algorithms: OK
            //- groups containing one blob 
            // - if this area is unique: 
            //     one algo missed the panel
            // - if the blob is contained in another bigger panel: 
            //     one algo returned one panel actually made of several panels. 
            //     Discard the panel containing the other panels... and order them correctly! 

            //Add confirmed blobs: those that both algoritms have found
            confirmedBlobs.AddRange(groups
                .Where(group => group.Value.Count == 2)
                .Select(group => group.Key));

            var unconfirmedBlobs = groups
                .Where(group => !confirmedBlobs.Contains(group.Key))
                .Select(group => group.Key)
                .ToList();

            //Find and remove a panel containing at least two other panels
            var supersetBlobs = new Dictionary<Blob, List<Blob>>();
            foreach (var unconfirmedBlob in unconfirmedBlobs)
            {
                var otherUnconfirmedBlobs = unconfirmedBlobs.Where(blob => blob != unconfirmedBlob);

                var unconfirmedRectangle = unconfirmedBlob.Rectangle.AddTolerance(tolerance);

                var containdedBlobs = otherUnconfirmedBlobs.Where(o => unconfirmedRectangle.Contains(o.Rectangle)).ToList();

                if (containdedBlobs.Count > 1)
                    supersetBlobs.Add(unconfirmedBlob, containdedBlobs);
            }

            unconfirmedBlobs = unconfirmedBlobs.Where(b => !supersetBlobs.Keys.Contains(b)).ToList();

            //Add remaining blobs
            confirmedBlobs.AddRange(unconfirmedBlobs);


            Debug.WriteLine($"Confirmed blobs: {confirmedBlobs.Count}");
            foreach (var blob in confirmedBlobs)
            {
                Debug.WriteLine($"- Key: {blob.ID}  X:{blob.Rectangle.X} Y:{blob.Rectangle.Y} W:{blob.Rectangle.Width} H:{blob.Rectangle.Height}");
            }

            return confirmedBlobs;
        }

        public override List<Bitmap> ExtractPanelsFromComicImagePage(Bitmap image, ComicConversionProfile profile)
        {
            var blobs = ExtractBlobPanelsFromComicImagePage(image, profile);

            var panelOrdering = new PanelOrderingWithBlokkers();
            var orderedBlobs = panelOrdering.OrderPanels(blobs, profile.PanelReadingDirection, 20);

            return ExtractPanelsFromComicImagePage(image, orderedBlobs, profile.IncludePageIfNoPanelDetected);
        }
    }
}
