using GetFolderDirection;
using JSON_task4_dll;
using System;

namespace Progrmam
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Select mode: \n 1. Tracking  mode \n 2. Rollback Mode");
            int Mode = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Mode); // Temp
            switch (Mode)
            {
                case 1: GetFolder.TrackingMode();
                    break;
                case 2: GetFolder.RollbackMode();
                    break;
            }
        }
    }
}