using used_frequently;

namespace _1._1._10_2D_array
{
    public class TwoDArray
    {
        public static void Main()
        {
            Console.WriteLine("2D array");
            Console.Write("enter array (n*n)length: ");
            int n = UsedFrequently.Try2Parse();
            int sum = 0;
            int[,] DArray = new int[n,n];
            for (int i = 0; i < DArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < DArray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0 && i + j != 0) {
                      DArray[i,j] = new Random().Next(-100, 100);
                      sum += DArray[i, j];
                    }
                    Console.Write(DArray[i,j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}