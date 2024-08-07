using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.Collections.Generic;
using System.IO;

namespace ComicStripToKindle
{
    public static class Sftp
    {
        public static List<string> ListDirectoryTree(string host, string username, string password, string remotePath="", int maxDepth=3)
        {
            List<string> directoryTree = new List<string>();
            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();
                ListDirectoryRecursive(sftp, remotePath, directoryTree, 0, maxDepth);
                sftp.Disconnect();
            }
            return directoryTree;
        }

        private static void ListDirectoryRecursive(SftpClient sftp, string path, List<string> directoryTree, int currentDepth, int maxDepth)
        {
            if (currentDepth > maxDepth)
            {
                return;
            }

            var files = sftp.ListDirectory(path);
            foreach (var file in files)
            {
                if (file.Name != "." && file.Name != "..")
                {
                    directoryTree.Add(file.FullName);
                    if (file.IsDirectory)
                    {
                        ListDirectoryRecursive(sftp, file.FullName, directoryTree, currentDepth + 1, maxDepth);
                    }
                }
            }
        }

        public static List<string> ListFilesInDirectory(string host, string username, string password, string remotePath)
        {
            List<string> filesList = new List<string>();
            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();
                var files = sftp.ListDirectory(remotePath);
                foreach (var file in files)
                {
                    if (!file.IsDirectory)
                    {
                        filesList.Add(file.FullName);
                    }
                }
                sftp.Disconnect();
            }
            return filesList;
        }

        public static void UploadFileToDirectory(string host, string username, string password, string localFilePath, string remoteDirectory)
        {
            using (var sftp = new SftpClient(host, username, password))
            {
                sftp.Connect();
                using (var fileStream = new FileStream(localFilePath, FileMode.Open))
                {
                    sftp.UploadFile(fileStream, Path.Combine(remoteDirectory, Path.GetFileName(localFilePath)));
                }
                sftp.Disconnect();
            }
        }
    }
}
