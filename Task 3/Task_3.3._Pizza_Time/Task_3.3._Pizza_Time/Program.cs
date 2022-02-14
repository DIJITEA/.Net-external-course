using _3._2._2_Super_array;
using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 9, 10, 11 };
            //Super_array TestArray = new Super_array(array1);
            //Console.WriteLine(TestArray.Sum());
            //Console.WriteLine(TestArray.MostFrequent());
            //Console.WriteLine(TestArray.Mean());
            //Console.WriteLine(TestArray.closestToTheMean());
            Super_array superArray = new Super_array();
            Super_array_Delegates.IntDelegate sum = new Super_array_Delegates.IntDelegate(superArray.Sum);
            Super_array_Delegates.DoubleDelegate mean = new Super_array_Delegates.DoubleDelegate(superArray.Mean);
            Super_array_Delegates.IntDelegate closestToTheMean = new Super_array_Delegates.IntDelegate(superArray.ClosestToTheMean);
            Super_array_Delegates.IntDelegate mostFrequent = new Super_array_Delegates.IntDelegate(superArray.MostFrequent);
            Console.WriteLine(sum(array1));
            Console.WriteLine(mean(array1));
            Console.WriteLine(closestToTheMean(array1));
            Console.WriteLine(mostFrequent(array1));
        }
    }
}