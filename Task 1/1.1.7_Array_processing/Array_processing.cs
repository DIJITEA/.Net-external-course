using used_frequently;

namespace _1._1._7_Array_processing
{
    public class ArrayProcessing
    {
        public static void Main()
        {
            Console.WriteLine("Array Processing");
            Console.Write("enter array length: ");
            int n = UsedFrequently.Try2Parse();
            int[] UnsortedArray = UsedFrequently.ArrayRandomize(n);
            Console.WriteLine($"Unsorted Array: {String.Join(" ", UnsortedArray)}");

            int[] SortedArray = UsedFrequently.QSort(UnsortedArray, 0, UnsortedArray.Length - 1);
            Console.WriteLine($"Sorted Array: {String.Join(" ", SortedArray)}");

            Console.WriteLine($"Min array item: {SortedArray[0]}");
            Console.WriteLine($"Max array item: {SortedArray[^1]}");
        }
    }
}