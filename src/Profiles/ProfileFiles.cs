using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ComicStripToKindle.Profiles
{
    public class ProfileFiles
    {
        private const string ProfilesDirectory = @"Profiles";

        string ProfileDirectoryPath => Path.Combine(FileSystemUtilities.AssemblyDirectory, ProfilesDirectory);

        private const string ImageEnhancementProfileExtension = @".iep";

        void CreateProfileDirectory()
        {
            if (!Directory.Exists(ProfileDirectoryPath))
                Directory.CreateDirectory(ProfileDirectoryPath);
        }

        public List<ImageEnhancementProfile> LoadImageEnhancementProfiles()
        {
            try
            {
                var imageEnhancementProfiles =
                    Directory.GetFiles(ProfileDirectoryPath, $"*{ImageEnhancementProfileExtension}");

                if (!imageEnhancementProfiles.Any())
                    return new List<ImageEnhancementProfile>();

                return imageEnhancementProfiles
                    .Select(JsonFile.Load<ImageEnhancementProfile>)
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (DirectoryNotFoundException)
            {
                CreateProfileDirectory();
                return new List<ImageEnhancementProfile>();
            }
        }

        public void Save(ImageEnhancementProfile profile)
        {
            CreateProfileDirectory();

            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ImageEnhancementProfileExtension}");

            JsonFile.Save(fileName, profile);
        }
        public void Delete(ImageEnhancementProfile profile)
        {
            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ImageEnhancementProfileExtension}");

            if (File.Exists(fileName))
                File.Delete(fileName);
        }

        private const string OutputProfileFileName = "OutputProfile.op";
        public string OutputProfilePath => Path.Combine(FileSystemUtilities.AssemblyDirectory, ProfilesDirectory, OutputProfileFileName);

        public OutputProfile LoadOutputProfile()
        {
            return File.Exists(OutputProfilePath)
                ? JsonFile.Load<OutputProfile>(OutputProfilePath)
                : new OutputProfile();
        }

        public void Save(OutputProfile profile)
        {
            CreateProfileDirectory();

            JsonFile.Save(OutputProfilePath, profile);
        }

        private const string ElectronicReaderProfileExtension = @".erp";


        public List<ElectronicReaderProfile> LoadElectronicReaderProfiles()
        {
            try
            {
                var electronicReaderProfiles =
                    Directory.GetFiles(ProfileDirectoryPath, $"*{ElectronicReaderProfileExtension}");

                if (!electronicReaderProfiles.Any())
                    return new List<ElectronicReaderProfile>();

                return electronicReaderProfiles
                    .Select(JsonFile.Load<ElectronicReaderProfile>)
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (DirectoryNotFoundException)
            {
                CreateProfileDirectory();
                return new List<ElectronicReaderProfile>();
            }
        }

        public void Save(ElectronicReaderProfile profile)
        {
            CreateProfileDirectory();

            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ElectronicReaderProfileExtension}");

            JsonFile.Save(fileName, profile);
        }
        public void Delete(ElectronicReaderProfile profile)
        {
            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ElectronicReaderProfileExtension}");

            if (File.Exists(fileName))
                File.Delete(fileName);
        }

        private const string ComicConversionProfileExtension = @".ccp";

        public List<ComicConversionProfile> LoadComicConversionProfiles()
        {
            try
            {
                var electronicReaderProfiles =
                    Directory.GetFiles(ProfileDirectoryPath, $"*{ComicConversionProfileExtension}");

                if (!electronicReaderProfiles.Any())
                    return new List<ComicConversionProfile>();

                return electronicReaderProfiles
                    .Select(JsonFile.Load<ComicConversionProfile>)
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            catch (DirectoryNotFoundException)
            {
                CreateProfileDirectory();
                return new List<ComicConversionProfile>();
            }
        }

        public void Save(ComicConversionProfile profile)
        {
            CreateProfileDirectory();

            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ComicConversionProfileExtension}");

            JsonFile.Save(fileName, profile);
        }
        public void Delete(ComicConversionProfile profile)
        {
            var fileName = Path.Combine(
                ProfileDirectoryPath,
                $"{FileSystemUtilities.MakeValidFileName(profile.Name)}{ComicConversionProfileExtension}");

            if (File.Exists(fileName))
                File.Delete(fileName);
        }
    }
}
