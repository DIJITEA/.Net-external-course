using used_frequently;

namespace _1._1._1_Rectangle
{
    public class Rectangle
    {
        public static void Main()
        {
            int RectangleArea = 0;
            Console.Write("enter 'a' side: ");
            int a = UsedFrequently.Try2Parse();
            //RectangleArea = Try2Parse(a);
            Console.Write("enter 'b' side: ");
            int b = UsedFrequently.Try2Parse();
            RectangleArea = a * b;
            Console.Write($"Rectangle area = {RectangleArea}");

        }
    }
}