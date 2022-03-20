using ChangesLogger;
namespace GetFolderDirection
{
    public class GetFolder
    {
        private string _folderDirection;
        public void TrackingMode(string folderDirection)
        {
            new FileTracking(_folderDirection);
            this._folderDirection = folderDirection;
        }
        public void RollbackMode(string folderDirection)
        {
            new FileRollback();
            this._folderDirection = folderDirection;
        }

    }
    public class DrivesInfo
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public void Drives()
        {
            Console.WriteLine("Available drive:");
            foreach (var d in allDrives)
            {
                Console.WriteLine(" Drive name: {0} \n type: {1}", d.Name, d.DriveType);
            }
        }
    }
    public class FolderInfo
    {

        public FileInfo[] Filesw()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"D:\EPAM_test_folder_task4");
            FileInfo[] files = dinfo.GetFiles("*.txt");
            Console.WriteLine("Available \".txt\" files:");

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(i + ". " + files[i].Name);
            }
            return files;
        }
    }
    public class FileRollback
    {
        public FileRollback()
        {
            GetHistoty();
            Console.ReadKey();
        }
        private static void GetHistoty()
        {
            Console.Write("Enter year \"yyyy\": ");
            string year = Console.ReadLine();
            Console.Write("Enter month \"mm\": ");
            string month = Console.ReadLine();
            Console.Write("Enter day \"dd\": ");
            string day = Console.ReadLine();
            Console.Write("Enter hour \"hh\": ");
            string hour = Console.ReadLine();
            Console.Write("Enter minute \"mm\": ");
            string minute = Console.ReadLine();

            var parsedDate = DateTime.Parse($"{day}/{month}/{year} {hour}:{minute}:00");
            Console.WriteLine(parsedDate);

            new GetChanges(@"D:\EPAM_test_folder_task4", parsedDate);
            Console.WriteLine("logs ");
            Console.ReadLine();
        }

    }
    public class FileTracking
    {
        private string _folderDirection;
        public FileTracking(string folderDirection)
        {
            Tracker();
            _folderDirection = folderDirection;
        }
        private void Tracker()
        {
            using var watcher = new FileSystemWatcher(_folderDirection);
            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;



            Console.ReadLine();
        }


        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            string value = $"Changed: {e.Name}";
            new GetChanges(e.FullPath, e.Name, 1);

            Console.WriteLine(value);

        }
        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Deleted: {e.FullPath}");
        }
        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed:");
            Console.WriteLine($"    Old: {e.OldFullPath}");
            Console.WriteLine($"    New: {e.FullPath}");
            new GetChanges(e.FullPath, e.OldFullPath, e.Name, 2);
        }
    }
}