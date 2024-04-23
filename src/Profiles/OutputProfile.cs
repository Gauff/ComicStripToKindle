namespace ComicStripToKindle.Profiles
{
    public class OutputProfile
    {
        public string Directory { get; set; }
        public bool UploadOnEreader { get; set; }
        public bool SendByEmail { get; set; }
        public bool OpenDirectoryAfterConversion { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string Password { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
