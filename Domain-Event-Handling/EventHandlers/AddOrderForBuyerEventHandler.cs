using System;
using System.Threading;
using System.Threading.Tasks;
using Domain_Event_Handling.BuyerAggregate;
using Domain_Event_Handling.DomainEvents;
using Domain_Event_Handling.OrderAggregate;
using MediatR;

namespace Domain_Event_Handling.EventHandlers
{
    public class
        AddOrderForBuyerEventHandler : INotificationHandler<
            OrderRegisteredDomainEvent>
    {
        public async Task Handle(OrderRegisteredDomainEvent orderStartedEvent,
            CancellationToken cancellationToken)
        {
            var orderName = orderStartedEvent.Order.Name;
            var orderTotalPrice = orderStartedEvent.Order.TotalPrice;
            var buyerOrder = new Order(orderName, orderTotalPrice);
            var buyer = new Buyer
                ("sample", buyerOrder, "1234567890", new Address());
            buyer.CheckNationalCodeValidity();
            var information = await buyer.GetInformation();
            Console.WriteLine(information);
        }
    }
}