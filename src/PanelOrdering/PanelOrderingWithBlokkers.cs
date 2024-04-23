using AForge.Imaging;
using ComicStripToKindle.Extensions;
using ComicStripToKindle.Profiles;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;


namespace ComicStripToKindle.PanelOrdering
{
    public class PanelOrderingWithBlokkers : IPanelOrdering
    {
        public List<Blob> OrderPanels(List<Blob> blobs, PanelReadingDirection panelReadingDirection, int tolerance)
        {
            var orderedBlobs = new List<Blob>();

            if (panelReadingDirection == (PanelReadingDirection.LeftToRight))
                OrderPanelsTopDownLeftRightRecursive(blobs, ref orderedBlobs, tolerance);
            else
                OrderPanelsTopDownRightLeftRecursive(blobs, ref orderedBlobs, tolerance);

            return orderedBlobs;
        }

        static void OrderPanelsTopDownLeftRightRecursive(IReadOnlyList<Blob> blobs, ref List<Blob> orderedBlobs, int tolerance)
        {
            if (blobs == null || blobs.Count == 0)
                return;

            if (blobs.Count == 1)
            {
                orderedBlobs.Add(blobs[0]);
                return;
            }

            var lines = blobs
                .OrderBy(b => b.Rectangle.Y)
                .ThenBy(b => b.Rectangle.X)
                .GroupByWithTolerance(b => b.Rectangle.Y, tolerance)
                .ToList();

            if (lines.Count == 1)
            {
                orderedBlobs.AddRange(lines.First());
                return;
            }

            foreach (var line in lines)
            {
                var alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();
                var lineBlobs = line
                    .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                    .OrderBy(b => b.Rectangle.X)
                    .ToList();

                if (lineBlobs.Count == 0)
                    continue;

                //Test simplest case: all cases are the same height
                if (lineBlobs
                        .Select(b => b.Rectangle.Height)
                        .GroupByWithTolerance(h => h, tolerance)
                        .Count() == 1)
                {
                    orderedBlobs.AddRange(lineBlobs);
                    continue;
                }

                //If some cases are taller, they are probably blokkers
                //Let's divide in 3 areas: before blokker, blokker, after blokker
                // var lineBlobs = line.ToList();

                var maxHeight = lineBlobs.Max(b => b.Rectangle.Height);
                var blokkers = lineBlobs.Where(b => b.Rectangle.Height == maxHeight);
                //RESOLVE LIST BLOKKERS: 
                var blokker = blokkers.First();

                var beforeBlokker = lineBlobs.TakeWhile(b => b.ID != blokker.ID).ToList();

                var usedBlobIds = beforeBlokker.Select(b => b.ID).ToList();
                usedBlobIds.Add(blokker.ID);
                var afterBlokker = lineBlobs.Where(b => !usedBlobIds.Contains(b.ID)).ToList();

                if (beforeBlokker.Count > 0) //Blokker could be the first, so no blob before it...
                {
                    var x = beforeBlokker.Min(b => b.Rectangle.X);
                    var y = beforeBlokker.Min(b => b.Rectangle.Y);
                    var width = blokker.Rectangle.X - x;
                    var height = blokker.Rectangle.Height;

                    var beforeBlokkerArea = new Rectangle(x, y, width, height).AddTolerance(tolerance);

                    alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();

                    var beforeBlokkerAreaBlobs = blobs
                        .Where(b => beforeBlokkerArea.Contains(b.Rectangle))
                        .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                        .ToList();

                    OrderPanelsTopDownLeftRightRecursive(beforeBlokkerAreaBlobs, ref orderedBlobs, tolerance);
                }

                orderedBlobs.Add(blokker);

                if (afterBlokker.Count <= 0)
                    continue;
                {
                    var x = afterBlokker.Min(b => b.Rectangle.X);
                    var y = afterBlokker.Min(b => b.Rectangle.Y);
                    var xMax = afterBlokker.Max(b => b.Rectangle.X + b.Rectangle.Width);
                    var width = xMax - blokker.Rectangle.X;
                    var height = blokker.Rectangle.Height;

                    var afterBlokkerArea = new Rectangle(x, y, width, height).AddTolerance(tolerance);

                    alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();

                    var afterBlokkerAreaBlobs = blobs
                        .Where(b => afterBlokkerArea.Contains(b.Rectangle))
                        .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                        .ToList();

                    OrderPanelsTopDownLeftRightRecursive(afterBlokkerAreaBlobs, ref orderedBlobs, tolerance);
                }
            }
        }

        static void OrderPanelsTopDownRightLeftRecursive(IReadOnlyList<Blob> blobs, ref List<Blob> orderedBlobs, int tolerance)
        {
            if (blobs == null || blobs.Count == 0)
                return;

            if (blobs.Count == 1)
            {
                orderedBlobs.Add(blobs[0]);
                return;
            }

            var lines = blobs
                .OrderBy(b => b.Rectangle.Y)
                .ThenByDescending(b => b.Rectangle.X + b.Rectangle.Width)
                .GroupByWithTolerance(b => b.Rectangle.Y, tolerance)
                .ToList();

            if (lines.Count == 1)
            {
                orderedBlobs.AddRange(lines.First());
                return;
            }

            foreach (var line in lines)
            {
                var alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();
                var lineBlobs = line
                    .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                    .OrderByDescending(b => b.Rectangle.X + b.Rectangle.Width)
                    .ToList();

                if (lineBlobs.Count == 0)
                    continue;

                //Test simplest case: all cases are the same height
                if (lineBlobs
                        .Select(b => b.Rectangle.Height)
                        .GroupByWithTolerance(h => h, tolerance)
                        .Count() == 1)
                {
                    orderedBlobs.AddRange(lineBlobs);
                    continue;
                }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //If some cases are taller, they are probably blokkers
                //Let's divide in 3 areas: before blokker, blokker, after blokker
                //                         right           middle   left
                var maxHeight = lineBlobs.Max(b => b.Rectangle.Height);
                var blokkers = lineBlobs.Where(b => b.Rectangle.Height == maxHeight);
                //RESOLVE LIST BLOKKERS: 
                var blokker = blokkers.First();

                var beforeBlokker = lineBlobs.TakeWhile(b => b.ID != blokker.ID).ToList();

                var usedBlobIds = beforeBlokker.Select(b => b.ID).ToList();
                usedBlobIds.Add(blokker.ID);
                var afterBlokker = lineBlobs.Where(b => !usedBlobIds.Contains(b.ID)).ToList();

                if (beforeBlokker.Count > 0) //Blokker could be the first, so no blob before it...
                {
                    var x = beforeBlokker.Max(b => b.Rectangle.X + b.Rectangle.Width);
                    var y = beforeBlokker.Min(b => b.Rectangle.Y);
                    var xMin = beforeBlokker.Min(b => b.Rectangle.X);
                    var width = x - xMin;
                    var height = blokker.Rectangle.Height;

                    var beforeBlokkerArea = new Rectangle(xMin, y, width, height).AddTolerance(tolerance);

                    alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();

                    var beforeBlokkerAreaBlobs = blobs
                        .Where(b => beforeBlokkerArea.Contains(b.Rectangle))
                        .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                        .ToList();

                    OrderPanelsTopDownRightLeftRecursive(beforeBlokkerAreaBlobs, ref orderedBlobs, tolerance);
                }

                orderedBlobs.Add(blokker);

                if (afterBlokker.Count <= 0)
                    continue;
                {
                    var x = afterBlokker.Max(b => b.Rectangle.X + b.Rectangle.Width);
                    var y = afterBlokker.Min(b => b.Rectangle.Y);
                    var xMin = afterBlokker.Min(b => b.Rectangle.X);
                    var width = x - xMin;
                    var height = blokker.Rectangle.Height;

                    var afterBlokkerArea = new Rectangle(xMin, y, width, height).AddTolerance(tolerance);

                    alreadyOrderedBlobIds = orderedBlobs.Select(b => b.ID).ToList();

                    var afterBlokkerAreaBlobs = blobs
                        .Where(b => afterBlokkerArea.Contains(b.Rectangle))
                        .Where(b => !alreadyOrderedBlobIds.Contains(b.ID))
                        .ToList();

                    OrderPanelsTopDownRightLeftRecursive(afterBlokkerAreaBlobs, ref orderedBlobs, tolerance);
                }
            }
        }

    }
}
