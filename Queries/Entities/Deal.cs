using System;

namespace Queries.Entities
{
    public class Deal
    {
        public int Id { get; }
        public int ClientCardId { get; }
        public string Client { get; }
        public int EmployeeId { get; }
        public string Employee { get; }
        public string Station { get; }
        public string SupplyType { get; }
        public double SupplyTypeAmount { get; }
        public int DiscountPercent { get; }
        public double Price { get; }
        public DateTime Date { get; }

        public Deal(int clientCardId, string station, int employeeId, string supplyType, double supplyTypeAmount, double price, DateTime date)
        {
            Station = station;
            SupplyType = supplyType;
            ClientCardId = clientCardId;
            EmployeeId = employeeId;
            SupplyTypeAmount = supplyTypeAmount;
            Price = price;
            Date = date;
        }

        public Deal(int id, int clientCardId, string supplyType, double supplyTypeAmount, double price, DateTime date)
        {
            Id = id;
            ClientCardId = clientCardId;
            SupplyType = supplyType;
            SupplyTypeAmount = supplyTypeAmount;
            Price = price;
            Date = date;
        }

        public Deal(int id, int clientCardId, string client, string employee, string station, string supplyType, double supplyTypeAmount,
            int discountPercent, double price, DateTime date)
        {
            Id = id;
            ClientCardId = clientCardId;
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
            return Price / ((double)(100 - DiscountPercent) / 100);
        }

        public double CountDiscount()
        {
            return CountFullPrice() - Price;
        }
    }
}
