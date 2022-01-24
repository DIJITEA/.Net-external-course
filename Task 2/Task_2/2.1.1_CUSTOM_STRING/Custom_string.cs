namespace _2._1._1_CUSTOM_STRING
{
    public class Custom_string
    {
        private char[] _charArray;  
        public string inputString    
        {
            set => _charArray = value.ToCharArray();
        }

        public char[] charArray
        {
            get => _charArray;
        }

        public void charArrayOutput()
        {
            for (int i =0; i < charArray.Length; i++)
            {
                Console.Write($"[{charArray[i]}]");
            }
        }

        private char[] _charArray2;

        public string inputString2
        {
            set => _charArray2 = value.ToCharArray();
        }
        // 2 charArr equals
        private static bool equals(char[] _charArray , char[] _charArray2)
        {
            for (int i = 0; i < _charArray.Length; i++)
            {
                if (_charArray[i] != _charArray2[i]) return false;
            }
            return true;
        }

        public bool equalsOutput
        {
            get => equals(_charArray, _charArray2);
        }
        // char arr join

        public string outputJoinString
        {
            get => outputJoinStringLogic(_charArray);
        }

        private static string outputJoinStringLogic(char[] _charArray)
        {
            Console.WriteLine("enter joiner:");
            string joinEl= Console.ReadLine();
            string output = "";
            for (int i = 0; i< _charArray.Length; i++)
            {
                output = output + _charArray[i] + joinEl;
            }
            output = output[0..^joinEl.Length];
            return output;
        }

        public string outputString
        {
            get => new string(_charArray);
        }

    }

    public class Custom_string__Call
    {
        public static void Main()
        {
            Custom_string customString = new Custom_string();
            Console.WriteLine("Enter the first string");
            customString.inputString = Console.ReadLine();
            Console.WriteLine($"String: {customString.outputString}");
            Console.WriteLine($"Char array:");
            customString.charArrayOutput();
            Console.WriteLine();
            Console.Write("enter string to compare with the first one: ");
            customString.inputString2 = Console.ReadLine();
            Console.WriteLine(customString.equalsOutput);
            Console.WriteLine(customString.outputJoinString);
        }
    }
}