namespace used_frequently
{
    public class UsedFrequently
    {
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
                        result = 0;
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

        public static int Try2ParseLessThenN(int n)
        {
            int result = 0;
            while (result == 0)
            {
                int rtnValue = Try2Parse();
                if (rtnValue <= n)
                {
                    result = rtnValue;
                }
                else
                {
                    Console.WriteLine("the input can't exceed the allowed value (out of range)");
                    Console.Write("enter the value again: ");
                }
            }
            return result;
        }
    }
}