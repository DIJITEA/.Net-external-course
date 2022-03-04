using Newtonsoft.Json;
using System.Text;

namespace JSON_task4_dll
{
    public class JsonClass
    {
        private string _jsonPath = @"D:\EPAM_test_folder_task4\path.json";

        private List<data> _dataList = new List<data>();
        private data _data = new data();
        private async Task GetCurrentLogs()
        {
            if (File.Exists(_jsonPath))
            {
                using (FileStream fs = File.OpenRead(_jsonPath))
                {
                    byte[] buffer = new byte[fs.Length];
                    await fs.ReadAsync(buffer, 0, buffer.Length);
                    string json = Encoding.Default.GetString(buffer);

                    _dataList = JsonConvert.DeserializeObject<List<data>>(json);

                    foreach(data data in _dataList)
                    {
                        string Path = data.Path;
                    }
                }
            }
            else 
            {
                using (FileStream fs = File.Create(_jsonPath));
            }
        }
        public async void LogCreate(string FileTextData, string FileFullPath, string FileName)
        {
            await GetCurrentLogs();
            this._data.Path = FileFullPath;
            this._data.Name = FileName;
            this._data.Id = Guid.NewGuid();
            this._data.Time = DateTime.Now;
            this._data.Message = FileTextData;

            _dataList.Add(this._data);

            string json = JsonConvert.SerializeObject(this._dataList);
            
            File.WriteAllText(_jsonPath, json);
        }
        public async void LogUpdate(string FileTextData, string FileFullPath, string FileName, string FileOldPath)
        {
            await GetCurrentLogs();
            foreach (data data in _dataList)
            {
                if (data.Path == FileOldPath)
                {

                    data.Name = FileName;
                    data.Path = FileFullPath;
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Path);
                }  
            }
            string json = JsonConvert.SerializeObject(this._dataList);
            File.WriteAllText(_jsonPath, json);
        }
        public async void GetFileHistory(string FileName)
        {
            await GetCurrentLogs();
            Console.WriteLine(FileName + " history:");
            foreach (data data in _dataList)
            {
                if (data.Name == FileName)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine(data.Id);
                    Console.WriteLine(data.Time);
                    Console.WriteLine(data.Message);
                    Console.WriteLine("--------------------");
                }
            }
        }
    }
    public class data
    {
        public string Path { get; set; }   
        public string Name { get; set; }    
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
    public class testDec
    {
        //public string Path 
    }


}