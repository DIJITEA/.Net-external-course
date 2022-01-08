namespace _1._2._3_LowerCase
{
    public class Lowercase
    {
        public static void Main()
        {
            Console.WriteLine("Lowercase");
            string inputStr = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputStr))
            {
                inputStr = System.Text.RegularExpressions.Regex.Replace(inputStr, @"[^\w]", " ");
                int counter = 0;
                if (Char.IsLower(inputStr[0]))
                {
                    counter++;
                }
                for (int i = 1; i < inputStr.Length; i++)
                {
                    if (inputStr[i - 1] == ' ' && Char.IsLower(inputStr[i]))
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }   else
            {
                Console.WriteLine("Error: string is empty or null");
            }
        }
    }
}