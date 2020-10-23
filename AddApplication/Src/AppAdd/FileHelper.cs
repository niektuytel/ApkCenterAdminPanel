using Newtonsoft.Json;
using System;
using System.IO;

namespace AddApplication.Src.AppAdd
{
    class FileHelper<T> 
    {
        public FileHelper()
        { }

        public void WriteJson(string filename, T data)
        {
            PrepareFile(filename);

            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();

                //serialize object directly into file stream
                serializer.Serialize(file, data);
            }
        }
        public T ReadJson(string filename, T data)
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

    }

}
