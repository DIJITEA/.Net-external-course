using used_frequently;

namespace _1._1._3_Another_triangle
{
    public class AnotherTriangle
    {
        public static void Main()
        {
            Console.WriteLine("Another triangle");
            Console.Write("enter n: ");
            int n = UsedFrequently.Try2Parse();
            //TriangleOutput(n);
            string[,] TriangleArray = TriangleOutput(n);
            for (int i = 0; i < TriangleArray.GetLength(0); i++)
            {
                for (int j = 0; j < TriangleArray.GetLength(1); j++)
                {
                    Console.Write(TriangleArray[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static string[,] TriangleOutput(int n)
        {
            int k = (n * 2) - 1;
            string[,] triangleArr;
            triangleArr = new string[n, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    triangleArr[i, j] = " ";
                    if (j == (k / 2))
                    {
                        triangleArr[i, j] = "*";
                        triangleArr[i, j + i] = "*";
                        triangleArr[i, j - i] = "*";
                    }
                    else if (j >= (k / 2) - i && j < (k / 2))
                    {
                        triangleArr[i, j] = "*";
                    }
                    else if (j > (k / 2) && j <= (k / 2) + i)
                    {
                        triangleArr[i, j] = "*";
                    }

                    //Console.Write(triangleArr[i, j]);
                    

                }
            }
            return triangleArr;
        }

    }
}