using Renci.SshNet;
using System;
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
            // Ensure the remote directory exists
            using (var sshClient = new SshClient(GetConnectionInfo(host, username, privateKeyPath)))
            {
                sshClient.Connect();

                // Create remote directory if it does not exist
                var createDirectoryCommand = $"mkdir -p \"{remoteDirectory}\"";
                var cmd = sshClient.CreateCommand(createDirectoryCommand);
                cmd.Execute();

                if (cmd.ExitStatus != 0)
                {
                    throw new Exception($"Failed to create directory. Error: {cmd.Error}");
                }

                sshClient.Disconnect();
            }

            // Upload the file
            using (var scpClient = new ScpClient(GetConnectionInfo(host, username, privateKeyPath)))
            {
                scpClient.Connect();

                FileInfo localFileInfo = new FileInfo(localFilePath);

                var remoteFilePath = Path.Combine(remoteDirectory, Path.GetFileName(localFilePath)).Replace(@"\", @"/");
                //var quotedRemoteFilePath = $"\"{remoteFilePath}\"";

                scpClient.Upload(localFileInfo, remoteFilePath);
                scpClient.Disconnect();
            }
        }
    }
}