using ComicStripToKindle.Extensions;

namespace ComicStripToKindle.ComicsPages
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    abstract class ComicPagesProvider : IComicPagesProvider
    {
        public class ComicPagesProviderProgressEventArgs : EventArgs
        {
            public string SourceFilePath { get; set; }
            public float Percentage { get; set; }
            public int CurrentPage { get; set; }
            public string Description { get; set; }
        }
        public event EventHandler<ComicPagesProviderProgressEventArgs> Progression;

        public string ComicPagesSourceFilePath { get; set; }
        public bool UnSkew { get; set; }
        public bool VerticalSplit { get; set; }
        public bool InvertPages { get; set; }

        protected ComicPagesProvider(
            string comicPagesSourceFilePath,
            bool unSkew,
            bool verticalSplit,
            bool invertPages)
        {
            ComicPagesSourceFilePath = comicPagesSourceFilePath;
            UnSkew = unSkew;
            VerticalSplit = verticalSplit;
            InvertPages = invertPages;
        }

        public abstract ComicPages ExtractPages();
        public abstract ComicPages ExtractRandomPage();

        public void UnSkewPage(string filePath)
        {
            if (!UnSkew)
                return;

            using (var imageWithBorder = ImageFilters.AddWhiteBorder(filePath))
            {
                using (var skewcheckedImage = ImageFilters.SkewCheck(imageWithBorder))
                    skewcheckedImage.SaveToTiffFile(filePath);
            }
        }

        public List<string> VerticalSplitPage(List<string> comicFilePaths)
        {
            if (!VerticalSplit)
                return comicFilePaths;

            var updatedcomicFilePaths = new List<string>();

            var pageNumber = 0;
            foreach (var comicFilePath in comicFilePaths)
            {
                pageNumber++;
                OnComicPagesProviderProgress(pageNumber, "Split Verticaly");

                var splitPages = ImageFilters.VerticalSplit(comicFilePath, InvertPages);

                updatedcomicFilePaths.AddRange(splitPages);
                if (splitPages.Count == 2)
                    File.Delete(comicFilePath);
            }

            return updatedcomicFilePaths;
        }

        public List<string> VerticalSplitPage(string comicFilePath)
        {
            if (!VerticalSplit)
                return new List<string> { comicFilePath };

            var updatedcomicFilePaths = ImageFilters.VerticalSplit(comicFilePath, InvertPages);
            File.Delete(comicFilePath);

            return updatedcomicFilePaths;
        }

        protected virtual void OnComicPagesProviderProgress(int currentPage, string description, float percentage = 0.0f)
        {
            Progression?.Invoke(this, new ComicPagesProviderProgressEventArgs
            {
                SourceFilePath = ComicPagesSourceFilePath,
                CurrentPage = currentPage,
                Description = description,
                Percentage = percentage
            });
        }
    }
}
