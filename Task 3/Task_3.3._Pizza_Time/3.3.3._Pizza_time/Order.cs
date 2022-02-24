namespace _3._3._3._Pizza_time
{
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
}