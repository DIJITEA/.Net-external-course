using used_frequently;

namespace _1._1._2_Triangle
{
    public class Triangle
    {
        public static void Main()
        {
            Console.WriteLine("Triangle");
            Console.Write("enter n: ");
            int n = UsedFrequently.Try2Parse();
            for (int i = 1; i <= n; i++)
            {
                string TriangleLine = "";
                for (int j = 1; j <= i; j++)
                {
                    TriangleLine = TriangleLine + '*';
                }
                    Console.WriteLine(TriangleLine);
                
                
            }

        }
    }
}