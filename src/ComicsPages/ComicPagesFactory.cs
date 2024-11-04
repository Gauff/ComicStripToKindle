using System;
using System.Diagnostics;
using System.IO;

namespace ComicStripToKindle.ComicsPages
{
    static class ComicPagesFactory
    {
        public static IComicPagesProvider Build(string path, bool unSkew, bool verticalSplit, bool invertPages)
        {
            if (Directory.Exists(path))
                return new DirectoryComicPagesProvider(path, unSkew, verticalSplit, invertPages);

            if (!File.Exists(path))
                throw new FileNotFoundException($"File {path} not found");

            var fileInfo = new FileInfo(path);
            switch (fileInfo.Extension.ToLowerInvariant())
            {
                case ".zip":
                case ".rar":
                case ".cbz":
                case ".cbr":
                    return new ArchiveComicPagesProvider(path, unSkew, verticalSplit, invertPages);

                case ".pdf":
                    return new PdfComicPagesProvider(path, unSkew, verticalSplit, invertPages);

                default:
                    Debug.WriteLine($"{fileInfo.Extension.ToLowerInvariant()} file type is not supported");
                    throw new Exception($"{fileInfo.Extension.ToLowerInvariant()} file type is not supported");
            }
        }
    }
}
