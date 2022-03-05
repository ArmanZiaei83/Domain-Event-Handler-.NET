using System;
using System.Threading.Tasks;
using Domain_Event_Handling.OrderAggregate;

namespace Domain_Event_Handling.BuyerAggregate
{
    public class Buyer
    {
        public string Name { get; }
        public Order Order { get; }
        public string NationalCode { get; }
        public Address Address { get; }

        public Buyer(string name, Order order, string nationalCode, Address address)
        {
            Name = name;
            Order = order;
            NationalCode = nationalCode;
            Address = address;
        }

        public void CheckNationalCodeValidity()
        {
            if (NationalCode.Length < 10)
                throw new Exception("InvalidNationalCodeException");
        }
        
        public async Task<string> GetInformation()
        {
            var name = $"Buyer's Name: {Name}";
            var orderName = $"Buyer's Order Name: {Order.Name}";
            var nationalCode = $"Buyer's National Code: {NationalCode}";
            return name + "\n" + nationalCode + "\n" + orderName + "\n";
        }
    }
}