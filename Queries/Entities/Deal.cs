using System;

namespace Queries.Entities
{
    public class Deal
    {
        public int Id { get; }
        public string Client { get; }
        public string Employee { get; }
        public string Station { get; }
        public string SupplyType { get; }
        public int SupplyTypeAmount { get; }
        public int DiscountPercent { get; }
        public int Price { get; }
        public DateTime Date { get; }


        public Deal(int id, string client, string employee, string station, string supplyType, int supplyTypeAmount,
            int discountPercent, int price, DateTime date)
        {
            Id = id;
            Client = client;
            Employee = employee;
            Station = station;
            SupplyType = supplyType;
            SupplyTypeAmount = supplyTypeAmount;
            DiscountPercent = discountPercent;
            Price = price;
            Date = date;
        }

        public double CountFullPrice()
        {
            return Price + Price * ((double) DiscountPercent / 100);
        }

        public double CountDiscount()
        {
            return Price * ((double) DiscountPercent / 100);
        }
    }
}
