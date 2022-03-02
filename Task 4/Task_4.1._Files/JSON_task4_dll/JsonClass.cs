using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;
namespace JSON_task4_dll
{
    public class JsonClass
    {
        private string _jsonPath = @"D:\EPAM_test_folder_task4\path.json";
        private Dictionary<string, List<data>> _dataDictionary = new Dictionary<string, List<data>>();
        //_dataDictionary = JsonConvert.DeserializeObject<Dictionary<string, List<data>>>(json);
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
                    string textFromFile = Encoding.Default.GetString(buffer);
                    //dynamic deserialized = JsonConvert.DeserializeObject(textFromFile);
                    List<data>? weatherForecast =
                     JsonSerializer.Deserialize<List<data>>(textFromFile);
                    weatherForecast.ForEach(i => Console.WriteLine(i.Time));
                    Console.WriteLine(weatherForecast);
                }
            } else
            {
                using (FileStream fs = File.Create(_jsonPath));
            }
        }
        public async void Main(string FileTextData, string FileFullPath)
        {
            await GetCurrentLogs();
            this._data.Path = FileFullPath;
            this._data.Id = Guid.NewGuid();
            this._data.Time = DateTime.Now;
            this._data.Message = FileTextData;

            //Id = Guid.NewGuid(),
            //Time = DateTime.Now,
            //Message = FileTextData
            _dataList.Add(this._data);
            _dataList.Add(this._data);
            //_dataDictionary.Add(FileFullPath, this._dataList);
            //Console.WriteLine(this._data);
            string json = JsonSerializer.Serialize(this._dataList);
            
            File.WriteAllText(_jsonPath, json);
        }
    }
    public class data
    {
        public string Path { get; set; }    
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
    public class testDec
    {
        //public string Path 
    }

}