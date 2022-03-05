using System.Collections.Generic;

namespace Domain_Event_Handling.OrderAggregate
{
    public class Order
    {
        public string Name { get; }

        public int TotalPrice { get; }

        public List<OrderItem> OrderItems { get; }

        public Order(string name, int totalPrice)
        {
            Name = name;
            TotalPrice = totalPrice;
            OrderItems = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }
    }
}