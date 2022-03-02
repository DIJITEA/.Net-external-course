using GetFolderDirection;
using JSON_task4_dll;
using System;

namespace Progrmam
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Select mode: \n 1. Vie mode \n 2. History mode");
            int Mode = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Mode); // Temp
            GetFolder.Test();
        }
    }
}