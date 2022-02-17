namespace _3._3._3._Pizza_time
{
    public class Pizza_time
    {
        public static void Main()
        {
            //PizzeriaView pizzeria = new PizzeriaView();
            //pizzeria.Generation();
            //Display.display();
            Person person1 = new Person();
            Person person2 = new Person();
            //person1.returnMain();
        }
    }
    //public class Display
    //{
    //    public static async void display()
    //    {
    //        await Task.Run(() =>
    //        {
    //            for (int i = 0; i < 10; i++)
    //            {
    //                Console.WriteLine(i);
    //                Thread.Sleep(200);
    //            }
    //        });
    //    }
    //}
    public class Pizzeria
    {
        private static int _count = 0;
        private static Dictionary<int, string> _id = new Dictionary<int, string>();
        private static Dictionary<int, string> _orderStatus = new Dictionary<int, string>();
        //private PizzeriaView pizzeriaAnimations = new PizzeriaView();
        private static string orderReturn (string order)
        {
            Console.WriteLine();
            _count++;
            _id.Add(_count, order);
            display(_count);
            return _count.ToString();
        }
        public static string setOrder(string order)
        {
            return orderReturn(order);
        }
        private static async void display(int id)
        {
            await Task.Run(() =>
            {
                _orderStatus.Add(id, "in progress");
                PizzeriaView.displayVie = _orderStatus;
                Thread.Sleep(5000);
                _orderStatus[id] = "ready";
                Console.WriteLine(_orderStatus[id]);
            });
        }

    }
    public class Order 
    {
        private PizzeriaView bakerAnimations = new PizzeriaView();
        private string _order;
        
        public Order(string source)
        {
            this._order = source;
        }
        public string SendOrder()
        {
            string orderId = Pizzeria.setOrder(this._order);
            this.bakerAnimations.BakerDialog($"your order id {orderId}, when the order is ready the message will appear on the display");
            return orderId;
        }
    }
    public class Person 
    {
        private PizzeriaView personAnimations = new PizzeriaView();
        private string _orderId;
        //private string _name;
        //private string _surname;
        public Person()
        {
            this.personAnimations.Start();
            orderCreate(Console.ReadLine());
            //this.output = $"{this._name} {this._surname} {this.order}";
        }
        private void orderCreate(string str)
        {
            Order order = new Order(str);
            this._orderId = order.SendOrder();
            this.personAnimations.GoBack();
        }
        //public string Name { get { return this._name; } set { this._name = value; } }
        //public string Surname { get { return this._surname; } set { this._surname = value; } }
    }
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