using System;
using System.Threading;
using System.Threading.Tasks;
using Domain_Event_Handling.DomainEvents;
using Domain_Event_Handling.EventHandlers;
using Domain_Event_Handling.OrderAggregate;

namespace Domain_Event_Handling
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var handler = new AddOrderForBuyerEventHandler();
            var orderToAdd = new Order("my-order", 4561);
            var status = handler.Handle(new OrderRegisteredDomainEvent(orderToAdd), CancellationToken.None).GetAwaiter();
            Console.WriteLine($"Status: {status.IsCompleted}");
        }
    }
}