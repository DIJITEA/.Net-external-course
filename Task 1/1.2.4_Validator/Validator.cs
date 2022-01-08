namespace _1._2._4_Validator
{
    public class Validator
    {
        public static void Main()
        {
            Console.WriteLine("Validator");
            string inputStr = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputStr))
            {
                string outputStr = inputStr[0].ToString().ToUpper();

                for (int i = 1; i < inputStr.Length; i++)
                {
                    if (inputStr[i] == '.' || inputStr[i] == '?' || inputStr[i] == '!' && inputStr[i] != inputStr[inputStr.Length - 1])
                    {
                        outputStr = outputStr + inputStr[i];
                        i++;
                        while (inputStr[i] == ' ')
                        {
                            outputStr = outputStr + inputStr[i];
                            i++;
                        }
                        outputStr = outputStr + (inputStr[i].ToString().ToUpper());
                    }
                    else
                    {
                        outputStr = outputStr + inputStr[i];
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