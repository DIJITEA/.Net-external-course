using used_frequently;

namespace _1._1._9_Non_negative_sum
{
    public class NonNegativeSum
    {
        public static void Main()
        {
            Console.WriteLine("Non-Negative Sum");
            Console.Write("enter array length: ");
            int n = UsedFrequently.Try2Parse();
            int[] Array = UsedFrequently.ArrayRandomize(n);
            int sum = 0;
            Console.WriteLine($"Unsorted Array: {String.Join(" ", Array)}");
            foreach (int i in Array)
            {
              sum += i > 0 ? i : 0;
            }
            Console.WriteLine(sum);
        }
    }
}