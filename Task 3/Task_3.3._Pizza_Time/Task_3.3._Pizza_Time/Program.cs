using _3._2._2_Super_array;
using _3._3._2._SUPER_STRING;
using _3._3._3._Pizza_time;
using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Pizza_time.Main();

            //Task_1_Super_array super_array = new Task_1_Super_array();
            //super_array.ConsoleOutput();

            //Task_2_Super_string super_string = new Task_2_Super_string();
            //super_string.ConsoleOutput();
        }
    }
    public class Task_1_Super_array
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 9, 10, 11 };
        static Super_array superArray = new Super_array();
        Super_array_Delegates.IntDelegate sum = new Super_array_Delegates.IntDelegate(superArray.Sum);
        Super_array_Delegates.DoubleDelegate mean = new Super_array_Delegates.DoubleDelegate(superArray.Mean);
        Super_array_Delegates.IntDelegate closestToTheMean = new Super_array_Delegates.IntDelegate(superArray.ClosestToTheMean);
        Super_array_Delegates.IntDelegate mostFrequent = new Super_array_Delegates.IntDelegate(superArray.MostFrequent);
        public void ConsoleOutput()
        {
            Console.WriteLine(this.sum(this.array1));
            Console.WriteLine(this.mean(this.array1));
            Console.WriteLine(this.closestToTheMean(this.array1));
            Console.WriteLine(this.mostFrequent(this.array1));
        }
    }
    public class Task_2_Super_string
    {
        Super_string str = new Super_string();
        public void ConsoleOutput()
        {
            string input = Console.ReadLine();
            Console.WriteLine(this.str.stringReturn(input));
        }
    }
}