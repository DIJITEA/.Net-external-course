namespace _3._3._2._SUPER_STRING
{
    public class Super_string
    {
        public string stringReturn(string test)
        {
            int switcher = 0;
            char[] stringChar = test.ToLower().ToCharArray();
            foreach (char ch in stringChar)
            {
                if (ch != ' ')
                {
                    if( ch>= 'а' && ch <= 'я' && (switcher == 0 || switcher == 3))
                    {
                        switcher = 3;
                    }
                    else if(ch >= '0' && ch <= '9' && (switcher == 0 || switcher == 1) )
                    {
                        switcher = 1;
                     
                    }
                        
                    else if(ch >= 'a' && ch <= 'z' && (switcher == 0 || switcher == 2))
                    { 
                        switcher = 2;
                    }
                    else switcher = 4;     
                }

                
            }
            switch (switcher)
            {
                case 0: 
                    return "empty";
                    break;
                case 1:
                    return "number";
                    break;
                case 2:
                    return "English";
                    break;
                case 3:
                    return "Russian";
                    break;
                case 4:
                    return "Mixed";
                    break;

            }
            
            return test;
        }
    }
}