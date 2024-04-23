using System.Collections.Generic;

namespace ComicStripToKindle.Profiles
{
    public static class PredefinedProfiles
    {
        public static List<ElectronicReaderProfile> ElectronicReaderProfiles => new List<ElectronicReaderProfile>
        {
            new ElectronicReaderProfile
            {
                Name = "Kindle 7th generation",
                HorizontalResolution = 600,
                VerticalResolution = 800,
                GammaCorrection = 2.0f,
                Grayscale = true
            }
        };


        public static List<ComicConversionProfile> ComicConversionProfiles => new List<ComicConversionProfile>
        {
            new ComicConversionProfile
            {
                Name = "Franco-Belgian comics",
                PanelReadingDirection = PanelReadingDirection.LeftToRight,
            }
        };
    }
}