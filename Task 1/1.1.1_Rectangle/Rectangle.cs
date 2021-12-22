namespace _1._1._1_Rectangle
{
    public class Rectangle
    {
        public static void Main()
        {
            int RectangleArea = 0;
            Console.Write("enter 'a' side: ");
            int a = Try2Parse();
            //RectangleArea = Try2Parse(a);
            Console.Write("enter 'b' side: ");
            int b = Try2Parse();
            RectangleArea = a * b;
            Console.Write($"Rectangle area = {RectangleArea}");

        }
        public static int Try2Parse()
        {
            int result = 0;
            while (result == 0)
            {
                string UnparsedValue = Console.ReadLine();
                if (Int32.TryParse(UnparsedValue, out result))
                {
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("input can only have numeric values greater than zero");
                        Console.Write("enter the value again: ");
                    }

                }
                else
                {
                    Console.WriteLine("input can only have numeric values");
                    Console.Write("enter the value again: ");
                }
            }
            return result;
        }
    }
}