using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStripToKindle.ComicsPages
{
    class DirectoryComicPagesProvider : ComicPagesProvider
    {
        public DirectoryComicPagesProvider(string comicPagesSourceFilePath, bool unSkew, bool verticalSplit)
            : base(comicPagesSourceFilePath, unSkew, verticalSplit)
        {
        }

        public override ComicPages ExtractPages()
        {
            string tempDirectory = null;

            try
            {
                tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();

                var originalDirectoryFiles = Directory
                    .EnumerateFiles(ComicPagesSourceFilePath, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
                    .Where(x => new FileInfo(x).Length > 0)
                    .ToList();

                foreach (var file in originalDirectoryFiles)
                {
                    var fi = new FileInfo(file);
                    var copiedFilePath = Path.Combine(tempDirectory, fi.Name);

                    File.Copy(file, copiedFilePath);
                }

                var comicFilePaths = Directory
                    .EnumerateFiles(tempDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
                    .ToList()
                    .Where(x => new FileInfo(x).Length > 0)
                    .ToList();

                comicFilePaths = VerticalSplitPage(comicFilePaths);

                Parallel.ForEach(
                    comicFilePaths,
                    DegreeOfParallelism.AllProcessorsButOne,
                    (currentFile) =>
                    {
                        UnSkewPage(currentFile);
                    });

                return BuildComicPages(comicFilePaths, tempDirectory);
            }
            catch
            {
                if (!string.IsNullOrEmpty(tempDirectory) && Directory.Exists(tempDirectory))
                    Directory.Delete(tempDirectory, true);

                throw;
            }
        }

        public override ComicPages ExtractRandomPage()
        {
            string tempDirectory = null;

            try
            {
                tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();

                var originalDirectoryFiles = Directory
                    .EnumerateFiles(ComicPagesSourceFilePath, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
                    .Where(x => new FileInfo(x).Length > 0)
                    .ToList();

                if (originalDirectoryFiles.Count > 5)
                {
                    var fi = new FileInfo(originalDirectoryFiles[4]);
                    var copiedFilePath = Path.Combine(tempDirectory, fi.Name);
                    File.Copy(originalDirectoryFiles[4], copiedFilePath);
                }

                var comicFilePaths = Directory.EnumerateFiles(tempDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
                    .ToList()
                    .Where(x => new FileInfo(x).Length > 0)
                    .ToList();

                return BuildComicPages(comicFilePaths, tempDirectory);
            }
            catch
            {
                if (!string.IsNullOrEmpty(tempDirectory) && Directory.Exists(tempDirectory))
                    Directory.Delete(tempDirectory, true);

                throw;
            }
        }

        private ComicPages BuildComicPages(List<string> comicFilePaths, string tempDirectory)
        {
            var i = 1;
            var comicPages = new ComicPages
            {
                Pages = comicFilePaths
                    .Select(x => new ExtractedPageResult
                    {
                        ExtractedPagePath = x,
                        PageNumber = i++
                    })
                    .ToList(),
                TemporaryExtractedPagesDirectoryPath = tempDirectory,
                SourceComicArchivePath = ComicPagesSourceFilePath
            };
            return comicPages;
        }
    }
}
