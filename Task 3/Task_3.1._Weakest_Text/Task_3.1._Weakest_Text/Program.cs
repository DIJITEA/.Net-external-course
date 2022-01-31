using used_frequently;
using _3._1._1_Weakest_link;
using System;
namespace Program
{
    public class Program
    {
        public static void Main()
        {
            NavigationBarConsole();
            NavigationBarGoTo();
        }
        
        private static void NavigationBarConsole()
        {
            Console.WriteLine("1. Weakest link");
            Console.WriteLine("2. Text Analysis");
        }
        private static void NavigationBarGoTo()
        {
            int switcher = UsedFrequently.Try2ParseLessThenN(2);
            switch (switcher)
            {
                case 1:
                    WeakestLink weakestList = new WeakestLink();
                    weakestList.Main();
                    break;
                case 2:
                    Console.WriteLine("in process");
                    Main();
                    break;
            }
        }
    }
}