using Newtonsoft.Json;
using System.IO;

namespace ComicStripToKindle
{
    public static class JsonFile
    {
        public static void Save<T>(string filePath, T obj)
        {
            File.WriteAllText(filePath, JsonConvert.SerializeObject(obj));
        }

        public static T Load<T>(string filePath)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(filePath));
        }
    }
}
