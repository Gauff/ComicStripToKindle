namespace ComicStripToKindle
{
    public static class FileExtensions
    {
        public static string[] AcceptedImageFileExtensions => new[]
        {
            ".bmp",
            ".gif",
            ".jpeg",
            ".jpg",
            ".png",
            ".tiff"
        };
    }
}