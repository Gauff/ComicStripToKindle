using ComicStripToKindle.Profiles;
using System;

namespace ComicStripToKindle.PanelExtraction
{
    public class BitmapPanelExtractionFactory
    {
        public static IBitmapPanelExtraction Build(PanelDetectionAlgorithm panelDetectionAlgorithm)
        {
            switch (panelDetectionAlgorithm)
            {
                case PanelDetectionAlgorithm.ByConnectedComponents:
                    return new ByConnectedComponentsBitmapPanelExtraction();

                case PanelDetectionAlgorithm.ByWhiteLinesDetection:
                    return new ByWhiteLinesDetectionBitmapPanelExtraction();

                case PanelDetectionAlgorithm.ByConnectedComponentsAndyWhiteLinesDetection:
                    return new ByConnectedComponentsAndWhiteLinesDetectionBitmapPanelExtraction();

                case PanelDetectionAlgorithm.CropWhiteBorders:
                    return new CropWhiteBordersBitmapPanelExtraction();

                case PanelDetectionAlgorithm.None:
                    return null;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
