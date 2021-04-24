using System;
using System.Collections.Generic;
using Queries.Entities;


namespace Queries.Interfaces
{
    public interface IStationRepository : IDisposable
    {
        int GetStationIdByName(string name);

        List<Station> GetStationsByCity(string city);

        List<Station> GetStations(bool workingStationsOnly);

        List<string> GetStationCities();

        void AddToStationTable(Station station);

        void UpdateStation(Station station);
    }
}
