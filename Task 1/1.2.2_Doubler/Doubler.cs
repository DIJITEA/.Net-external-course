namespace _1._2._2_Doubler
{
    public class Doubler
    {
        public static void Main()
        {
            Console.WriteLine("1.2.2 Doubler");
            string inputStr = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputStr))
            {
                string doublerStr = Console.ReadLine();
                string outputStr = "";

                for (int i = 0; i < inputStr.Length; i++)
                {
                    outputStr = outputStr + inputStr[i];
                    for (int j = 0; j < doublerStr.Length; j++)
                    {
                        if (inputStr[i] == doublerStr[j])
                        {
                            outputStr = outputStr + doublerStr[j];
                            break;
                        }
                    }
                }

                Console.WriteLine(outputStr);
            }   else
            {
                Console.WriteLine("Error: string is empty or null");
            }
        }
    }
}