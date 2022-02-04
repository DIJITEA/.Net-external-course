using System.Text.RegularExpressions;
namespace _1._2._1_Averages
{
    public class Averages
    {
        public static void Main()
        {
            Console.WriteLine("1.2.1 Averages");
            string inputStr = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputStr))
            {
                inputStr = Regex.Replace(inputStr, @"[^\w]", " ");

                string[] inputStrArray = inputStr.Split(' ');
                double averageLength = 0;
                int emptyElements = 0;

                foreach (string item in inputStrArray)
                {
                    if (item.Length == 0)
                    {
                        emptyElements++;
                    }
                    averageLength = averageLength + item.Length;
                }

                averageLength = averageLength / (inputStrArray.Length - emptyElements);
                Console.WriteLine(Math.Round(averageLength, 1));
            } else
            {
                Console.WriteLine("Error: string is empty or null");
            }
        }
    }
}