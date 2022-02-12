namespace _3._1._2_Text_analysis
{
    public class TextAnalysis
    {
        private static string _inputStr;
        private static string _rebuildedString;
        public void Main()
        {
            string temptest = RebuildString(GetString());
            var _inputStrVar = new StringProd(temptest);
            Console.WriteLine(temptest);
            _inputStrVar.dictionatyUpDate();
        }
        private static string GetString()
        {
            _inputStr = Console.ReadLine();
            return _inputStr;
        }
        private static string RebuildString(string s)
        {
            //s = Regex.Replace(s, @"[^\w]", " "); //short variant by Regex
            s = s.ToLower();
            var replaceCharArray = new char[] { ',', '?', '.', '!' };
            for (int i = 0; i < replaceCharArray.Length; i++)
            {
                s = s.Replace(replaceCharArray[i], ' ');
            }
            return s;
        }


    }
    public class StringProd
    {
        private static string _inputStr;
        public StringProd(string inputStr)
        {
            _inputStr = inputStr;
        }
        private static Dictionary<string, int> _checkingDictionary = new Dictionary<string, int>();
        public  void dictionatyUpDate()
        {
            string wordTemp = "";
            for (var i=0; i< _inputStr.Length; i++ )
            {
                while ( i < _inputStr.Length &&  _inputStr[i] != ' ') 
                {
                    wordTemp = wordTemp + _inputStr[i];
                    i++;
                }
                if (wordTemp != "")
                {
                    if (!_checkingDictionary.ContainsKey(wordTemp))
                    {
                        _checkingDictionary.Add(wordTemp, 1);
                    }
                    else _checkingDictionary[wordTemp] += 1;
                }

                wordTemp = "";
            }

            var sortedDict = from e in _checkingDictionary orderby e.Value descending select e;
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }
        }
    }
}