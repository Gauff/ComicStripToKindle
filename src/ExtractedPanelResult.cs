using ComicStripToKindle.ComicsPages;
using System;
using System.Collections.Generic;

namespace ComicStripToKindle
{
    public class ExtractedPanelResults
    {
        public ExtractedPageResult ExtractedPage { get; set; }
        public List<ExtractedPanelResult> ExtractedPanels { get; set; }
        public string TemporaryDirectory { get; set; }
    }

    public class ExtractedPanelResult
    {
        public int PanelNumber { get; set; }
        public string ExtractedPanelPath { get; set; }
        public Exception Exception { get; set; }
    }
}