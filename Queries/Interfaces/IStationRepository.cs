using System;
using System.Collections.Generic;
using Queries.Entities;


namespace Queries.Interfaces
{
    public interface IStationRepository : IDisposable
    {
        int FindStationIdByLocation(string location);

        List<Station> FindStations(string fCountry, string fCity);

        List<string> GetOrganizations();

        List<Station> GetStations();

        List<string> GetStationsAddress(string name);

        string GetStationAddressById(int stationId);

        void AddToStationTable(Station st);
    }
}
