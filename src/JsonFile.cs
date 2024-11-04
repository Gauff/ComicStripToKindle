using System.Runtime.Serialization.Json;
using System.IO;

namespace ComicStripToKindle
{
    public static class JsonFile
    {
        public static void Save<T>(string filePath, T obj)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.WriteObject(fs, obj);
            }
        }

        public static T Load<T>(string filePath)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (T)serializer.ReadObject(fs);
            }
        }
    }
}