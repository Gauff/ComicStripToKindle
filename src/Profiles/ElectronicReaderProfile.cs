namespace ComicStripToKindle.Profiles
{
    public enum ContrastCorrection
    {
        None,
        Automatic,
        Manual
    }

    public class ElectronicReaderProfile
    {
        public string Name { get; set; }

        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }

        public bool Grayscale { get; set; }

        public double? GammaCorrection { get; set; }

        public string VolumeName { get; set; }
        public string DocumentDirectory { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}
