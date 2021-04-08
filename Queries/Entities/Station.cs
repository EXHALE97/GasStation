namespace Queries.Entities
{
    public class Station
    {
        public int Id { get; }
        public string Name { get; }
        public string City { get; }
        public string Address { get; }
        public bool IsWorking{ get; }

        public Station(int id, string name, string city, string street, bool isWorking)
        {
            Id = id;
            Name = name;
            City = city;
            Address = street;
            IsWorking = isWorking;
        }

        public Station(string name, string city, string street, bool isWorking)
        {
            Name = name;
            City = city;
            Address = street;
            IsWorking = isWorking;
        }
    }
}
