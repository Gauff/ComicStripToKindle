using Renci.SshNet;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ComicStripToKindle
{
    public static class Scp
    {
        private static ConnectionInfo GetConnectionInfo(string host, string username, string privateKeyPath)
        {
            var keyFile = new PrivateKeyFile(privateKeyPath);
            var keyFiles = new[] { keyFile };
            var authMethod = new PrivateKeyAuthenticationMethod(username, keyFiles);
            return new ConnectionInfo(host, 22, username, authMethod);
        }

        public static List<string> ListDirectoryTree(string host, string username, string privateKeyPath, string remotePath, int maxDepth)
        {
            List<string> directoryTree = new List<string>();
            using (var client = new SshClient(GetConnectionInfo(host, username, privateKeyPath)))
            {
                client.Connect();
                string command = $"find {remotePath} -maxdepth {maxDepth}";
                var cmd = client.CreateCommand(command);
                string result = cmd.Execute();
                directoryTree = result.Split('\n').Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
                client.Disconnect();
            }
            return directoryTree;
        }

        public static List<string> ListFilesInDirectory(string host, string username, string privateKeyPath, string remotePath)
        {
            List<string> filesList = new List<string>();
            using (var client = new SshClient(GetConnectionInfo(host, username, privateKeyPath)))
            {
                client.Connect();
                string command = $"find {remotePath} -type f";
                var cmd = client.CreateCommand(command);
                string result = cmd.Execute();
                filesList = result.Split('\n')
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .OrderBy(line => line)
                    .ToList();
                client.Disconnect();
            }
            return filesList;
        }

        public static void UploadFileToDirectory(string host, string username, string privateKeyPath, string localFilePath, string remoteDirectory)
        {
            using (var client = new ScpClient(GetConnectionInfo(host, username, privateKeyPath)))
            {
                client.Connect();
                using (var fileStream = new FileStream(localFilePath, FileMode.Open))
                {
                    client.Upload(fileStream, Path.Combine(remoteDirectory, Path.GetFileName(localFilePath)).Replace(@"\", @"/"));
                }
                client.Disconnect();
            }
        }
    }
}