namespace _1._2._1_Averages
{
    public class Averages
    {
        public static void Main()
        {
            Console.WriteLine("1.2.1 Averages");
            string inputStr = Console.ReadLine();
            inputStr = System.Text.RegularExpressions.Regex.Replace(inputStr, @"[^\w]", " ");
            Console.WriteLine(inputStr);
            string [] inputStrArray = inputStr.Split(' ');
            int averageLength = 0;
            int emptyElements = 0;
            foreach (string item in inputStrArray)
            {  
             if (item.Length == 0)
                {
                    emptyElements++;
                    Console.WriteLine(item);
                }
               
                        averageLength = averageLength + item.Length;

            }
            averageLength = averageLength / (inputStrArray.Length - emptyElements);
            Console.WriteLine(averageLength);
        }
    }
}