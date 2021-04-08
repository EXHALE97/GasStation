using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

        public List<Station> GetStations()
        {
            var stationList = new List<Station>();
            try
            {

                DataBaseConnection.OpenConnection();
                var queryResult = new SqlCommand("EXEC StationsSummary", DataBaseConnection.GetConnection()).ExecuteReader();
                if (queryResult.HasRows)
                {
                    stationList.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Station(int.Parse(dbDataRecord["id"].ToString()), dbDataRecord["name"].ToString(),
                            dbDataRecord["city"].ToString(), dbDataRecord["address"].ToString(),
                            bool.Parse(dbDataRecord["is_working"].ToString())));
                }
                queryResult.Close();
            }
            finally { DataBaseConnection.CloseConnection(); }
            return stationList;
        }

        public List<Station> FindStations(string fCountry, string fCity)
        {
            List<Station> stationList = new List<Station>();
            DataBaseConnection.OpenConnection();
            try
            {
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"GasStation\" WHERE country LIKE" +
                " @fCountry AND city LIKE @fCity ");
                queryCommand.Parameters.AddWithValue("@fCountry", "%" + fCountry + "%");
                queryCommand.Parameters.AddWithValue("@fCity", "%" + fCity + "%");

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

        public int FindStationIdByLocation(string location)
        {
            int station_id = 0;
            try
            {

                List<string> splittedLocation = new List<string>();
                if (location != String.Empty)
                {
                    string[] split = location.Split(new Char[] { ',' });
                    foreach (string s in split)
                    {
                        splittedLocation.Add(s);
                    }
                    splittedLocation[2] = CheckRightStreet(splittedLocation[2]);
                }
                DataBaseConnection.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"GasStation\" WHERE country =" +
                  "'" + splittedLocation[0] + "' AND city =" + "'" + splittedLocation[1] + "'" + "AND street =" + "'" + splittedLocation[2] + "'" + "");

                //NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"GasStation\" WHERE country LIKE" +
                //  "'%" + splittedLocation[0] + "%' AND city LIKE" + "'%" + splittedLocation[1] + "%'" + "AND street LIKE" + "'%" + splittedLocation[2] + "%'" + "", dbc.getConnection());

                var Station_ID_TableSearcher = queryCommand.ExecuteReader();
                if (Station_ID_TableSearcher.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in Station_ID_TableSearcher)
                    {
                        station_id = Convert.ToInt32(dbDataRecord["station_id"]);
                    }
                }
                Station_ID_TableSearcher.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }
            return station_id;
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

        public void AddToStationTable(Station st)
        {
            try
            {
                DataBaseConnection.OpenConnection();

                var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"GasStation\"(OrgName, Country, City, Street, StorageCap)" +
                        "VALUES(@OrgName, @Country, @City, @Street, @StorageCap)");
                    queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { DataBaseConnection.CloseConnection(); }

        }

        private string CheckRightStreet(string street)
        {
            for (var i = 1; i < street.Length; i++)
            {
                if ((street[i] >= 'А' && street[i] <= 'Я') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= 'A' && street[i] <= 'Z') && (street[i - 1] >= 'a' && street[i - 1] <= 'z'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= '0' && street[i] <= '9') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= '0' && street[i] <= '9') && (street[i - 1] >= 'a' && street[i - 1] <= 'z'))
                {
                    street = street.Insert(i, " ");
                }
            }
            return street;
        }
    }
}
