namespace Queries.Entities
{
    public class Station
    {
        public int Id { get; }
        public string Name { get; }
        public string Country { get; }
        public string City { get; }
        public string Address { get; }

        public Station(int id, string name, string country, string city, string street)
        {
            Id = id;
            Name = name;
            Country = country;
            City = city;
            Address = street;
        }

        public Station(string name, string country, string city, string street)
        {
            Name = name;
            Country = country;
            City = city;
            Address = street;
        }
    }
}
