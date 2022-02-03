using _1._1._3_Another_triangle;
using used_frequently;

namespace _1._1._4_X_mas_tree
{
    public class XMassTree
    {
        public static void Main()
        {
            Console.WriteLine("X-mass tree");
            Console.Write("enter n: ");
            int n = UsedFrequently.Try2Parse();
            
            for (int i = 0; i < n; i++)
            {

                int test = i + 1;
                string[,] TriangleArray = AnotherTriangle.TriangleOutput(test);
                for (int j = 0; j < TriangleArray.GetLength(0); j++)
                {
                    Console.Write(SpaceString(n-i));
                    for (int k = 0; k < TriangleArray.GetLength(1); k++)
                    {
                        Console.Write(TriangleArray[j, k]);
                    }
                    Console.WriteLine();
                }

            }
        }
        public static string SpaceString(int iLength)
        {
            string spaceString = "";
            for (int i = 0; i < iLength; i++) {
                spaceString = spaceString + " ";
            }
            return spaceString;
        }
    }
}