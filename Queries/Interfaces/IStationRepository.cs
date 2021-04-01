using System;
using System.Collections.Generic;
using Queries.Entities;


namespace Queries.Interfaces
{
    public interface IStationRepository : IDisposable
    {
        int FindStationIDByLocation(string location);

        List<Station> FindStations(string fCountry, string fCity);

        List<string> GetOrganisations();

        List<Station> GetStations();

        List<string> GetStationsAdres(string Orgname);

        string GetStationAdresByID(int station_id);

        void AddToStationTable(Station st);

    }
}
