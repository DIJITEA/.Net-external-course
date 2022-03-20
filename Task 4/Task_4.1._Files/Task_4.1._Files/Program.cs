using GetFolderDirection;
using JSON_task4_dll;
using System;

namespace Progrmam
{
    public static class Program
    {
        public static void Main()
        {
            string _folderDirection = @"D:\EPAM_test_folder_task4";
            Console.WriteLine(" Select mode: \n 1. Tracking  mode \n 2. Rollback Mode");
            int Mode = Int32.Parse(Console.ReadLine());
            switch (Mode)
            {
                case 1: new GetFolder().TrackingMode(_folderDirection);
                    break;
                case 2: new GetFolder().RollbackMode(_folderDirection);
                    break;
            }
        }
    }
}