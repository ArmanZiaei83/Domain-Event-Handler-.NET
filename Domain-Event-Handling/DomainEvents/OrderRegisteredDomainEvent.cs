using Domain_Event_Handling.OrderAggregate;
using MediatR;

namespace Domain_Event_Handling.DomainEvents
{
    public class OrderRegisteredDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderRegisteredDomainEvent(Order order)
        {
            Order = order;
        }
    }
}