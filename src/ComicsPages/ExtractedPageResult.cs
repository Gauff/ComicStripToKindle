using System;

namespace ComicStripToKindle.ComicsPages
{
    public class ExtractedPageResult
    {
        public int PageNumber { get; set; }
        public string ExtractedPagePath { get; set; }

        public Exception Exception { get; set; }
    }
}
