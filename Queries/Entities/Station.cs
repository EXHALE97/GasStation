namespace Queries.Entities
{
    public class Station
    {
        public int s_station_id { private set; get; }
        public string s_orgname { private set; get; }
        public string s_country { private set; get; }
        public string s_city { private set; get; }
        public string s_street { private set; get; }
        public int s_storagecap { private set; get; }

        public void stationSet(int station_id, string orgname, string country, string city, string street, int storagecap)
        {
            s_station_id = station_id;
            s_orgname = orgname;
            s_country = country;
            s_city = city;
            s_street = street;
            s_storagecap = storagecap;
        }

        public void stationSet(string orgname, string country, string city, string street, int storagecap)
        {
            s_orgname = orgname;
            s_country = country;
            s_city = city;
            s_street = street;
            s_storagecap = storagecap;
        }

        public int GetStation_id() => s_station_id;
        public string GetOrgName() => s_orgname;
        public string GetCountry() => s_country;
        public string GetCity() => s_city;
        public string GetStreet() => s_street;
        public int GetStorageCap() => s_storagecap;
    }
}
