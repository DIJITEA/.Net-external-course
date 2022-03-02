using JSON_task4_dll;
using System.Text;
namespace ChangesLogger
{
    public class GetChanges
    {
        private string FileFullPath;
        public GetChanges(string FilePath) 
        {
            FileFullPath = FilePath;
            OpenFileStream();
        }
        private async Task OpenFileStream()
        {
            using (FileStream fs = File.OpenRead(this.FileFullPath))
            {
                byte[] buffer = new byte[fs.Length];
                await fs.ReadAsync(buffer, 0, buffer.Length);
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine(textFromFile);
                JsonClass test = new JsonClass();
                test.Main(textFromFile, this.FileFullPath);
            }
        }
    }
}