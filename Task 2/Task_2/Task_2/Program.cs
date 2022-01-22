using _2._1._1_CUSTOM_STRING;
using _2._1._2_CUSTOM_PAINT;
using used_frequently;
using System;


namespace Task2
{
    public static class TaskExtensions
    {
        public static void Main()
        {
            Console.WriteLine("1.Custom String");
            Console.WriteLine("2.Custom Paint");
            
            int selector = UsedFrequently.Try2ParseLessThenN(2);

            switch (selector)
            {
                case 1: 
                   Console.Clear();
                   Custom_string__Call.Main();
                   break;
                case 2:
                   Console.Clear();
                   Custom_paint.Main();
                   break;

            }

        }
    }
}