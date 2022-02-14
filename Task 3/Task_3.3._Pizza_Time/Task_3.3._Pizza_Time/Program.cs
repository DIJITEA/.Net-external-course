using _3._2._2_Super_array;
using System;

namespace Program
{
    public class Program
    { 
        public static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 10, 11 };
            Super_array TestArray = new Super_array(array1);
            Console.WriteLine(TestArray.Sum());
            Console.WriteLine(TestArray.MostFrequent());
            Console.WriteLine(TestArray.Mean());
            Console.WriteLine(TestArray.closestToTheMean());
        }
    }
}