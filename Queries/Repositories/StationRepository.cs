using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Support.Validators;

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

        public List<Station> FindStations(string country, string city)
        {
            List<Station> stationList = new List<Station>();
            DataBaseConnection.OpenConnection();
            try
            {
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"GasStation\" WHERE country LIKE" +
                " @fCountry AND city LIKE @fCity ");
                queryCommand.Parameters.AddWithValue("@fCountry", "%" + country + "%");
                queryCommand.Parameters.AddWithValue("@fCity", "%" + city + "%");

                var AZSTableSearcher = queryCommand.ExecuteReader();
                if (AZSTableSearcher.HasRows)
                {
                    stationList.AddRange(from DbDataRecord dbDataRecord in AZSTableSearcher
                        select new Station(Convert.ToInt32(dbDataRecord["station_id"]),
                            dbDataRecord["orgname"].ToString(), dbDataRecord["country"].ToString(),
                            dbDataRecord["city"].ToString(), bool.Parse(dbDataRecord["street"].ToString())));
                    AZSTableSearcher.Close();
                }
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }
            return stationList;
        }

        public List<string> GetStationsAddress(string Orgname)
        {
            List<string> comboBoxElements = new List<string>();
            try
            {
                DataBaseConnection.OpenConnection();
                var queryCommand = new SqlCommand("SELECT country, city, street FROM \"AZS\".\"GasStation\" WHERE orgname LIKE @Orgname ");
                queryCommand.Parameters.AddWithValue("@Orgname", "%" + Orgname + "%");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        comboBoxElements.Add(dbDataRecord["country"].ToString() + "," + dbDataRecord["city"].ToString() + "," + dbDataRecord["street"].ToString());
                    }
                    
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }

            return comboBoxElements;
        }

        public string GetStationAddressById(int stationId)
        {
            string location = String.Empty;
            var comboBoxElements = new List<string>();
            try
            {
                DataBaseConnection.OpenConnection();
                var queryCommand = new SqlCommand("SELECT country, city, street FROM \"AZS\".\"GasStation\" WHERE station_id = @Station_id ");
                queryCommand.Parameters.AddWithValue("@Station_id", stationId);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        location = dbDataRecord["country"].ToString() + "," + dbDataRecord["city"].ToString() + "," + dbDataRecord["street"].ToString();
                    }

                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }

            return location.Trim().Replace(" ", string.Empty);
        }

        public List<string> GetOrganizations()
        {
            List<string> comboBoxElements = new List<string>();

            try
            {
                DataBaseConnection.OpenConnection();
                var queryCommand = new SqlCommand("SELECT DISTINCT orgname FROM \"AZS\".\"GasStation\"");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        comboBoxElements.Add(dbDataRecord["orgname"].ToString());
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }

            return comboBoxElements;
        }

        public void AddToStationTable(Station station)
        {
            ExecuteSqlNonQueryCommand($"EXEC InsertStation N'{station.Name}', N'{station.City}', N'{station.Address}', {station.IsWorking.ToString()}");
        }

        public void UpdateStation(Station station)
        {
            ExecuteSqlNonQueryCommand($"EXEC UpdateStation {station.Id}, N'{station.Name}', N'{station.City}', N'{station.Address}', {station.IsWorking.ToString()}");
        }
    }
}
