namespace Queries.Entities
{
    public class SupplyType
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public bool IsSelling { get; }

        public SupplyType(int id, string name, double price, bool isSelling)
        {
            Id = id;
            Name = name;
            Price = price;
            IsSelling = isSelling;
        }

        public SupplyType(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}