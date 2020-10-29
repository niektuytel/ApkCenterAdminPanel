using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AddApplication.Src
{
    class FileHelper
    {

        public FileHelper()
        { }

        public void WriteJson<T>(string filename, T data)
        {
            PrepareFile(filename);

            using StreamWriter file = File.CreateText(filename);
            JsonSerializer serializer = new JsonSerializer();

            serializer.Serialize(file, data);
        }
        
        public T ReadJson<T>(string filename, T data)
        {
            if (PrepareFile(filename))
                return data;

            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
                data = JsonConvert.DeserializeObject<T>(json);
            }

            return data;
        }

        private bool PrepareFile(string filename)
        {
            if (!File.Exists(filename))
            {
                string path = Path.GetDirectoryName(filename);
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return true;
            }
            return false;
        }

        public string DataToJson<T>(T data)
        {
            MemoryStream stream = new MemoryStream();

            DataContractJsonSerializer serialiser = new DataContractJsonSerializer(
                data.GetType(),
                new DataContractJsonSerializerSettings()
                {
                    UseSimpleDictionaryFormat = true
                });

            serialiser.WriteObject(stream, data);

            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}
