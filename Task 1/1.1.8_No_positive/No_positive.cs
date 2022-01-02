using used_frequently;

namespace _1._1._8_No_positive
{
    public class NoPositive
    {
        public static void Main()
        {
            Console.WriteLine("1.1.8 No positive");
            Console.Write("enter array (n*n*n)length: ");
            int n = UsedFrequently.Try2Parse();
            int[,,] TArray = new int[n,n,n];

            for (int i = 0; i < TArray.GetLength(0); i++)
            {
                for (int j = 0; j < TArray.GetLength(1); j++)
                {
                    for (int  k = 0;   k< TArray.GetLength(1);  k++)
                    {
                        TArray[i, j, k] = new Random().Next(-100, 100);
                        TArray[i, j, k] = TArray[i, j, k] > 0 ? 0 : TArray[i, j, k];
                        Console.WriteLine(TArray[i, j, k]);
                    }
                }
            }
        }
    }
}