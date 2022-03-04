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
        private async Task OpenFileStream()
        {
            using (FileStream fs = File.OpenRead(this._FileFullPath))
            {
                byte[] buffer = new byte[fs.Length];
                await fs.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                JsonClass JsonCall = new JsonClass();
                switch (_switcher)
                {
                    case 1:
                        JsonCall.LogCreate(textFromFile, this._FileFullPath, this._FileFullName);
                        break;
                        case 2:
                        JsonCall.LogUpdate(textFromFile, this._FileFullPath, this._FileFullName, this._OldFullPath);
                        break;
                        case 3:
                        JsonCall.GetFileHistory(this._FileFullName);
                        break;
                }
                //JsonCall.Main(textFromFile, this._FileFullPath, this._FileFullName);
            }
        }
    }
}