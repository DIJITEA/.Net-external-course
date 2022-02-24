namespace _3._3._3._Pizza_time
{
    public class PizzeriaView
    {
        private string[] _baker = { "  ☻    ", " /#l ╣ ", "  ║  ║ " };
        private string[] _pizzeriaGreeting = {"\nBaker: \n" +
            "- Welcome to the \"DoDoMinos\" pizzeria \n" +
            "- What will you order" };
        private string _customerStr = "\nCustomer: \n" +
            "- ";
        private static Dictionary<int, string> _display = new Dictionary<int, string>();
        public static Dictionary<int, string> displayVie { set => _display = value; }


        public async Task Start()
        {

            //Console.WriteLine($"\n" +
            //    "          o   \n" +
            //    "         /#l ╣\n" +
            //    "          ║  ║ "
            //    );
            //CustomerAnimation();
            CustomerGoToBakerAnimation();
            TimeSleepDialogs(this._pizzeriaGreeting[0]);
            TimeSleepDialogs(this._customerStr);
        }

        public void Display()
        {
            Console.WriteLine("\n Display: ");
            foreach (var value in _display)
            {
                Console.Write( $" {value.Key} {value.Value} |" );
            }
            Console.WriteLine();
        }


        public void BakerDialog(string str)
        {
            string bakerInitDialog = $"Baker: \n- {str}";
            TimeSleepDialogs(bakerInitDialog);
        }

        private  void TimeSleepDialogs(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                    Thread.Sleep(20);
            }
        }

        private void staticScene(string spaces)
        {
            Console.Clear();
            Display();
            string[] customerStatic = { " o ", "|X|", " ║ " };
            Console.WriteLine(_baker[0] + spaces + customerStatic[0]);
            Console.WriteLine(_baker[1] + spaces + customerStatic[1]);
            Console.WriteLine(_baker[2] + spaces + customerStatic[2]);

        }
        private  void CustomerGoToBakerAnimation()
        {
            string[] customerFirstShot = { "  o", "└ X›", "‹\\" };

            string[] customerSecondShot = { "  o", " ┘\\", "/‹" };

            string spaces = "          ";
            for (int i = 0; i < 10 ; i++)
            {
                spaces = spaces.Remove(0,1);
                Console.Clear();
                Display();
              
                if (i % 2 == 0)
                {
                    Console.WriteLine(_baker[0] + spaces + customerFirstShot[0]);
                    Console.WriteLine(_baker[1] + spaces + customerFirstShot[1]);
                    Console.WriteLine(_baker[2] + spaces + customerFirstShot[2]);
                } else
                {
                    Console.WriteLine(_baker[0] + spaces + customerSecondShot[0]);
                    Console.WriteLine(_baker[1] + spaces + customerSecondShot[1]);
                    Console.WriteLine(_baker[2] + spaces + customerSecondShot[2]);
                }
                //Console.Write(CustomerFirstShot[i]);
                Thread.Sleep(200);
            }

            staticScene(spaces);
        }
        public void GoBack()
        {
            CustomerGoFromBakerAnimation();
        }
        private void CustomerGoFromBakerAnimation()
        {
            string[] customerFirstShot = { "  o", "└ X›", "‹\\" };

            string[] customerSecondShot = { "  o", " ┘\\", "/‹" };

            string spaces = "";

            staticScene(spaces);

            for (int i = 0; i < 10; i++)
            {
                spaces += " ";
                Console.Clear();
                Display();
                if (i % 2 == 0)
                {
                    Console.WriteLine(_baker[0] + spaces + customerFirstShot[0]);
                    Console.WriteLine(_baker[1] + spaces + customerFirstShot[1]);
                    Console.WriteLine(_baker[2] + spaces + customerFirstShot[2]);
                }
                else
                {
                    Console.WriteLine(_baker[0] + spaces + customerSecondShot[0]);
                    Console.WriteLine(_baker[1] + spaces + customerSecondShot[1]);
                    Console.WriteLine(_baker[2] + spaces + customerSecondShot[2]);
                }
                //Console.Write(CustomerFirstShot[i]);
                Thread.Sleep(200);
            }
        }

    }
}