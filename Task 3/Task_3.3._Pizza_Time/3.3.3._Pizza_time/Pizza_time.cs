namespace _3._3._3._Pizza_time
{
    public class Pizza_time
    {
        public static void Main()
        {
            PizzeriaV2 pizzeria = PizzeriaV2.GetInstance();
            //Person person1 = new Person();
            OrderV2 order = new OrderV2();
            PersonV2 p1 = new PersonV2("Alex");
            PersonV2 p2 = new PersonV2("Bob");
        
            order.onNewOrder += p1.OrderSend;
            
            order.NewOrder();
            order.onNewOrder += p2.OrderSend;
            order.NewOrder();
            //while sync order check
        }
    }
}
public class OrderV2
{

    protected string _order;
    public delegate string[] MethodContainer();
    public event MethodContainer onNewOrder;
    public void NewOrder()
    {
        PizzeriaV2 pizzeria = PizzeriaV2.GetInstance();
        pizzeria.SetOrder(onNewOrder());
    }
}
public class PizzeriaV2
{
    private static PizzeriaV2 _instance;
    private static Dictionary<string, string> _orderStatus = new Dictionary<string, string>();

    public static PizzeriaV2 GetInstance() => _instance ?? (_instance = new PizzeriaV2());
    private PizzeriaV2()
    {

    }
    public void SetOrder(string[] s)
    {
        _orderStatus.Add(s[0], "order is not ready");
        Console.WriteLine(s[0] + '\n' + s[1]);
        //foreach (var value in _orderStatus)
        //{
        //    Console.WriteLine($" {value.Key} {value.Value} |");
        //}
        display(s[0]);
        Thread.Sleep(10000);
    }
    private static async void display(string name)
    {
        await Task.Run(() =>
        {
            Thread.Sleep(5000);
            _orderStatus[name] = name;
            Console.WriteLine(_orderStatus[name]);
        });
    }
}
public class PersonV2 : OrderV2
{
    public string Name;
    public PersonV2(string name)
    {
        this.Name = name;
        //OrderV2 order = new OrderV2();
    }

    public string[] OrderSend()
    {
        string order = "I'll have two number 9's, a number 9 large, a number 6 with extra dip, a number 7, two number 45s, one with cheese, and a large soda";
        string[] fullorder = {Name, order };
        return fullorder;
    }
}