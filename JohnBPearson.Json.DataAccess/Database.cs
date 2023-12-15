//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;
//using System.Web;
//using System.Windows.Forms;
//using System.Xml.Linq;

//namespace JohnBPearson.Json.DataAccess
//{
//    public class Database<T>
//    {
//        private string _fileName = "defaultDatabase.json";
//        private string _folderPath = ""; 

//        private Database() {
//            this._folderPath = Assembly.GetExecutingAssembly().Location;
//        }

//        private Database(string fileName)
//        {
//            this._fileName = fileName;
//            this._folderPath = Assembly.GetExecutingAssembly().Location;
//        }

//        private T Deserialize(string contents)
//        {   T listWrapper =
//                JsonSerializer.Deserialize<T>(contents);
//            return listWrapper;
            

//        }

//        private async Task Serialize(T listWrapper)
//        {
//            var result = "" = JsonSerializer.Serialize<T>(listWrapper);
//           return this.WriteFileAsync(this._folderPath, this._fileName, result);
//          //  return result;
//        }
//        public async Task<T> LoadData()
//        {
          
            
//           var stringResult= await  this.ReadFileAsync(this._folderPath, this._fileName);
//            var results = this.Deserialize(stringResult);
//          return results;
//        }


//        private async Task<string> ReadFileAsync(string dir, string file)
//        {
//            var filePath = System.IO.Path.Combine(dir, file);
//            using (FileStream sourceStream = new FileStream(filePath,
//       FileMode.Open, FileAccess.Read, FileShare.Read,
//       bufferSize: 4096, useAsync: true))
//            {
//                StringBuilder sb = new StringBuilder();

//                byte[] buffer = new byte[0x1000];
//                int numRead;
//                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
//                {
//                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
//                    sb.Append(text);
//                }

//                return sb.ToString();
//            }
//        }
//        public async void SaveData(string data)
//        {

//          await this.WriteFileAsync(this._folderPath, this._fileName, data);
//            //string jsonString = JsonSerializer.Serialize(items);
//           // File.WriteAllText(_fileName, jsonString);
//        }

//        private  async Task WriteFileAsync(string dir, string file, string content)
//        {
//            string fullPath = System.IO.Path.Combine(dir, file);
//            var info = new System.IO.FileInfo(fullPath);
//            var oldFullPath = System.IO.Path.Combine(dir, "xx" + file);
//            if (System.IO.File.Exists(fullPath))
//            {

//                info.CopyTo(oldFullPath);
            

//            } 
//            else
//            {
//                info.Create();
//            }
//            using (StreamWriter outputFile = new StreamWriter(fullPath))
//            {
//                return outputFile.WriteAsync(content);
//            }
//            if (System.IO.File.Exists(oldFullPath))
//            {
//                File.Delete(oldFullPath);
//            }
          
//        }
    


//        public static Database<T> CreateDataAccess()
//        {
//            return new Database<T>();

//        }
        

//    }
//}
