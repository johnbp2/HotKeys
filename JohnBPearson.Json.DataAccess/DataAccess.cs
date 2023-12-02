using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JohnBPearson.Json.DataAccess
{
    public class Database<T>
    {
        private string _fileName = "defaultDatabase.json";
        internal Database(string fileName)
        {
            this._fileName = fileName;
        }

        private List<T> Load()
        {   T weatherForecast =
                JsonSerializer.Deserialize<T>("");
            return new List<T>();


        }

        internal void SaveData(List<T> items)
        {

            string jsonString = JsonSerializer.Serialize(items);
            File.WriteAllText(_fileName, jsonString);
        }

        private static async Task WriteFileAsync(string dir, string file, string content)
        {
            string fullPath = System.IO.Path.Combine(dir, file);
            if (System.IO.File.Exists(fullPath))
            {
                var info = new System.IO.FileInfo(fullPath);
                var oldFullPath = System.IO.Path.Combine(dir, "xx" + file);
                info.CopyTo(oldFullPath);
                if (System.IO.File.Exists(oldFullPath))
                {
                    File.Delete(oldFullPath);
                }

            }
            using (StreamWriter outputFile = new StreamWriter(fullPath))
            {
                await outputFile.WriteAsync(content);
            }
        }
    

        private  async Task<string> ReadFileAsync(string dir, string file)
        {
            var filePath = System.IO.Path.Combine(dir, file);
            using (FileStream sourceStream = new FileStream(filePath,
       FileMode.Open, FileAccess.Read, FileShare.Read,
       bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }


        

    }
}
