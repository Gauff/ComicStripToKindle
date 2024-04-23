using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace ComicStripToKindle.ComicsPages
{
    class ArchiveComicPagesProvider : ComicPagesProvider
    {
        public ArchiveComicPagesProvider(string comicPagesSourceFilePath, bool unSkew, bool verticalSplit)
            : base(comicPagesSourceFilePath, unSkew, verticalSplit)
        {
        }

        public override ComicPages ExtractPages()
        {
            string tempDirectory = null;

            try
            {
                tempDirectory = FileSystemUtilities.CreateTemporaryDirectory();

                ExtractFilesToDirectory(tempDirectory);

                var comicFilePaths = Directory
                    .GetFiles(tempDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
                    .Where(x => new FileInfo(x).Length > 0)
                    .ToList();

                comicFilePaths = VerticalSplitPage(comicFilePaths);

                var pageNumber = 0;
                Parallel.ForEach(
                    comicFilePaths,
                    DegreeOfParallelism.AllProcessorsButOne,
                    (currentFile) =>
                    {
                        pageNumber++;
                        OnComicPagesProviderProgress(pageNumber, $"Unskewing {pageNumber}/{comicFilePaths.Count}", ((float)pageNumber / comicFilePaths.Count) * 100);
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

                ExtractRandomFileToDirectory(tempDirectory);

                var comicFilePaths = Directory
                    .EnumerateFiles(tempDirectory, "*.*", SearchOption.AllDirectories)
                    .Where(x => FileExtensions.AcceptedImageFileExtensions.Contains(new FileInfo(x.ToLowerInvariant()).Extension))
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

        private void ExtractFilesToDirectory(string tempDirectory)
        {
            var pageNumber = 0;
            try
            {
                using (Stream stream = File.OpenRead(ComicPagesSourceFilePath))
                using (var reader = ReaderFactory.Open(stream))
                {
                    while (reader.MoveToNextEntry())
                    {
                        if (!reader.Entry.IsDirectory)
                        {
                            pageNumber++;
                            OnComicPagesProviderProgress(pageNumber, "Extracting");

                            reader.WriteEntryToDirectory(tempDirectory, new ExtractionOptions
                            {
                                ExtractFullPath = true,
                                Overwrite = true,
                            });
                        }
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                if (e.Message.ToLowerInvariant().Contains("Cannot determine compressed stream type".ToLowerInvariant()))
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(ComicPagesSourceFilePath, tempDirectory);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        throw;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ExtractRandomFileToDirectory(string tempDirectory)
        {
            using (Stream stream = File.OpenRead(ComicPagesSourceFilePath))
            using (var reader = ReaderFactory.Open(stream))
            {
                var pageNumber = 0;

                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        pageNumber++;

                        if (pageNumber > 10)
                        {
                            reader.WriteEntryToDirectory(tempDirectory, new ExtractionOptions
                            {
                                ExtractFullPath = true,
                                Overwrite = true,
                            });

                            return;
                        }
                    }
                }
            }
        }
    }
}
