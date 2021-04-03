namespace Queries.Entities
{
    public class SupplyType
    {
        public string Name { get; }
        public string Price { get; }

        public SupplyType(string name, string price)
        {
            Name = name;
            Price = price;
        }
    }
}