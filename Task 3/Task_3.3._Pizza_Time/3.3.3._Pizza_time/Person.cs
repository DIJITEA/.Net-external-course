namespace _3._3._3._Pizza_time
{
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
}