using System;

namespace ComicStripToKindle.Profiles
{
    [Flags]
    public enum PanelReadingDirection
    {
        None = 0x0,

        LeftToRight = 0x1,
        RightToLeft = 0x2,

        //UpToDown = 0x4,
        //DownToUp = 0x8
    }

    [Flags]
    public enum PanelDetectionAlgorithm
    {
        None = 0x0,
        ByConnectedComponents = 0x1,
        ByWhiteLinesDetection = 0x2,
        ByConnectedComponentsAndyWhiteLinesDetection = 0x4,
        CropWhiteBorders = 0x8
    }

    public class ComicConversionProfile
    {
        public string Name { get; set; }

        public PanelReadingDirection PanelReadingDirection { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public bool UnSkew { get; set; }

        public int MinimumPanelSizeWidthFraction { get; set; }
        public int MinimumPanelSizeHeightFraction { get; set; }

        public PanelDetectionAlgorithm PanelDetectionAlgorithm { get; set; }

        public int WhiteBackgroundTreshold { get; set; }
        public bool BlackBackground { get; set; }
        public bool VerticalSplit { get; set; }
        public bool IncludePageIfNoPanelDetected { get; set; }

        public bool InvertPages { get; set; }
        public bool HorizontalLinesOnly { get; set; }
    }
}