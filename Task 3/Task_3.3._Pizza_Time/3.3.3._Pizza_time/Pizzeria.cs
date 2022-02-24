namespace _3._3._3._Pizza_time
{
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
}