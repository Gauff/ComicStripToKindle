using System.Collections.Generic;

namespace ComicStripToKindle.ComicsPages
{
    public class ComicPages
    {
        //Original comic archive or pdf file path
        public string SourceComicArchivePath { get; set; }

        public string TemporaryExtractedPagesDirectoryPath { get; set; }

        public List<ExtractedPageResult> Pages { get; set; }
    }
}
