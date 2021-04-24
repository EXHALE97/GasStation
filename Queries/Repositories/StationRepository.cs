using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class StationRepository : BaseRepository, IStationRepository
    {
        public StationRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {

        }

        public List<Station> GetStations(bool workingStationsOnly)
        {
            return ExecuteSqlCommand(workingStationsOnly ? "EXEC WorkingStationsSummary":"EXEC StationsSummary", queryResult =>
            {
                var stationList = new List<Station>();
                if (queryResult.HasRows)
                {
                    stationList.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Station(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["name"].ToString(),
                            dbDataRecord["city"].ToString(), dbDataRecord["address"].ToString(),
                            bool.Parse(dbDataRecord["is_working"].ToString())));
                }

                queryResult.Close();
                return stationList;
            });
        }

        public int GetStationIdByName(string name)
        {
            return ExecuteSqlCommand($"EXEC GetStationIdByName N'{name}'", queryResult =>
            {
                var id = 0;
                if (queryResult.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in queryResult)
                    {
                        id = int.Parse(dbDataRecord["id"].ToString());
                    }
                }

                queryResult.Close();
                return id;
            });
        }

        public List<Station> GetStationsByCity(string city)
        {
            return ExecuteSqlCommand($"EXEC GetStationsByCity N'{city}'", queryResult =>
            {
                var stationList = new List<Station>();
                if (queryResult.HasRows)
                {
                    stationList.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Station(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["name"].ToString(),
                            dbDataRecord["city"].ToString(), dbDataRecord["address"].ToString(),
                            bool.Parse(dbDataRecord["is_working"].ToString())));
                }

                queryResult.Close();
                return stationList;
            });
        }

        public List<string> GetStationCities()
        {
            return ExecuteSqlCommand($"EXEC GetAllStationCities", queryResult =>
            {
                var cities = new List<string>();
                if (queryResult.HasRows)
                {
                    cities.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select dbDataRecord["city"].ToString());
                }

                queryResult.Close();
                return cities;
            });
        }

        public void AddToStationTable(Station station)
        {
            ExecuteSqlNonQueryCommand($"EXEC InsertStation N'{station.Name}', N'{station.City}', N'{station.Address}', '{station.IsWorking.ToString()}'");
        }

        public void UpdateStation(Station station)
        {
            ExecuteSqlNonQueryCommand($"EXEC UpdateStation {station.Id}, N'{station.Name}', N'{station.City}', N'{station.Address}', '{station.IsWorking.ToString()}'");
        }
    }
}
