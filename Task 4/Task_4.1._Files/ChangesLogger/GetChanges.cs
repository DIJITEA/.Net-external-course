using JSON_task4_dll;
using System.Text;
namespace ChangesLogger
{
    public class GetChanges
    {
        private string _FileFullPath;
        private string _FileFullName;
        private string _OldFullPath;
        private int _switcher;
        private DateTime _RollDate;
        public GetChanges(string FilePath, string FileName, int switcher)
        {
            _FileFullPath = FilePath;
            _FileFullName = FileName;
            _switcher = switcher;
            OpenFileStream();
        }
        public GetChanges(string FilePath, string OldFullPath, string FileName, int switcher)
        {
            _FileFullPath = FilePath;
            _OldFullPath = OldFullPath;
            _FileFullName = FileName;
            _switcher = switcher;
            OpenFileStream();
        }
        public GetChanges(string FilePath, DateTime RollDate)
        {
            _FileFullPath = FilePath;
            _RollDate = RollDate;
            Console.WriteLine("Get Changes");
            Console.WriteLine(_switcher);
            Console.WriteLine(_RollDate);
            JsonClass JsonCall = new JsonClass();
            JsonCall.GetFileHistory(this._RollDate);
        }

        private async void OpenFileStream()
        {
            using (FileStream fs = File.OpenRead(this._FileFullPath))
            {
                Console.WriteLine("OpenFileStream");
                byte[] buffer = new byte[fs.Length];
                await fs.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                JsonClass JsonCall = new JsonClass();
                switch (_switcher)
                {
                    case 1:
                        Console.WriteLine("ask Changes");
                        JsonCall.LogCreate(textFromFile, this._FileFullPath, this._FileFullName);
                        break;
                    case 2:
                        Console.WriteLine("ask Changes");
                        JsonCall.LogUpdate(textFromFile, this._FileFullPath, this._FileFullName, this._OldFullPath);
                        break;
                    case 3:
                        Console.WriteLine("ask Changes");
                        JsonCall.GetFileHistory(this._RollDate);
                        break;
                }
            }
        }
    }
}