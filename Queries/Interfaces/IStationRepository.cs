using System;
using System.Collections.Generic;
using Queries.Entities;


namespace Queries.Interfaces
{
    public interface IStationRepository : IDisposable
    {
        int FindStationIdByLocation(string location);

        List<Station> FindStations(string country, string city);

        List<string> GetOrganizations();

        List<Station> GetStations(bool workingStationsOnly);

        List<string> GetStationsAddress(string name);

        string GetStationAddressById(int stationId);

        void AddToStationTable(Station station);
    }
}
