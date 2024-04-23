using AForge.Imaging;
using ComicStripToKindle.Profiles;
using System.Collections.Generic;

namespace ComicStripToKindle.PanelOrdering
{
    public interface IPanelOrdering
    {
        List<Blob> OrderPanels(List<Blob> blobs, PanelReadingDirection panelReadingDirection, int tolerance);
    }
}