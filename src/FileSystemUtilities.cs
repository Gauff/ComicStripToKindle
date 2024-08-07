using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ComicStripToKindle
{
    public static class FileSystemUtilities
    {
        public static string CreateTemporaryDirectory()
        {
            var tempDirectory = Path.Combine(Path.GetTempPath(), "ComicStripToKindle", Path.GetRandomFileName());
            Directory.CreateDirectory(tempDirectory);
            return tempDirectory;
        }

        public static void ClearTemporaryDirectories()
        {
            var tempDirectory = Path.Combine(Path.GetTempPath(), "ComicStripToKindle");

            if (Directory.Exists(tempDirectory))
                Directory.Delete(tempDirectory, true);
        }

        public static string AssemblyDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string MakeValidFileName(string name)
        {
            var invalidChars = new string(Path.GetInvalidFileNameChars());
            var escapedInvalidChars = Regex.Escape(invalidChars);
            var invalidRegex = string.Format(@"([{0}]*\.+$)|([{0}]+)", escapedInvalidChars);

            return Regex.Replace(name, invalidRegex, "_");
        }

        public static string AppendToFileName(string filePath, string textToAppend)
        {
            var fi = new FileInfo(filePath);

            return Path.Combine(fi.Directory.ToString(), $"{fi.Name.Remove(fi.Name.Length - fi.Extension.Length)}{textToAppend}{fi.Extension}");
        }

        public static bool IsHiddenDirectory(string path)
        {
            var directories = path.TrimEnd('/').Split('/');
            return directories.Any(dir => dir.StartsWith("."));
        }
    }
}
