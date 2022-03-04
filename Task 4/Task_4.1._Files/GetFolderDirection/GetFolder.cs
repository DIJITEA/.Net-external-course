using ChangesLogger;
using System.IO;
namespace GetFolderDirection
{
    public class GetFolder
    {
        public static void Test()
        {
            DrivesInfo test = new DrivesInfo();
            test.Drives();
            FolderInfo testFolder = new FolderInfo();
            testFolder.Filesw();

            FileTracking tracker = new FileTracking();
            tracker.Tracker();

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
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine(file.Name);
            //}
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(i + ". " + files[i].Name);
            }
            return files;
        }
    }
    public class FileTracking
    {
        public void Tracker()
        {
            using var watcher = new FileSystemWatcher(@"D:\EPAM_test_folder_task4");
            watcher.Created += OnCreated;
            watcher.Changed += OnChanged;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            TrackerTasks();

            Console.ReadLine();
        }

        private static void TrackerTasks()
        {
            Console.WriteLine("1. Get history");
            Console.WriteLine("2. rollback");
            int switcher = Convert.ToInt32(Console.ReadLine());
            switch (switcher)
            {
                case 1:
                    GetHistoty();
                    break;
            }

        }
        private static void GetHistoty()
        {
            FolderInfo testFolder = new FolderInfo();
            FileInfo[] files = testFolder.Filesw();
            Console.WriteLine("enter file number: ");
            int fileNum = Convert.ToInt32(Console.ReadLine());
            new GetChanges(files[fileNum].FullName, files[fileNum].Name, 3);
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