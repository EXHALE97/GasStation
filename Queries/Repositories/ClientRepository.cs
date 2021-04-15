﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {

        }

        public List<Client> GetClients()
        {
            return ExecuteSqlCommand("EXEC ClientsSummary", queryResult =>
            {
                var clients = new List<Client>();
                if (queryResult.HasRows)
                {

                    clients.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Client(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["first_name"].ToString(),
                            dbDataRecord["last_name"].ToString(), 
                            dbDataRecord["middle_name"].ToString(),
                            int.Parse(dbDataRecord["cred_id"].ToString()),
                            int.Parse(dbDataRecord["discount_percent"].ToString()), 
                            Convert.ToDateTime(dbDataRecord["activation_date"].ToString()),
                            dbDataRecord["cred_id"].ToString() == string.Empty
                                ? 0
                                : int.Parse(dbDataRecord["cred_id"].ToString())));
                }

                queryResult.Close();
                return clients;
            });
        }

        public int FindCarIDByCardnum(string cardnum)
        {
            int car_id = 0;
            //try
            //{
            //    dbc.OpenConnection();
            //    var queryCommand = new SqlCommand("SELECT car_id FROM \"AZS\".\"Car\" WHERE cardnum = @Cardnum");
            //    queryCommand.Parameters.AddWithValue("@CardNum", cardnum);
            //    var AZSTableReader = queryCommand.ExecuteReader();
            //    if (AZSTableReader.HasRows)
            //    {
            //        foreach (DbDataRecord dbDataRecord in AZSTableReader)
            //        {
            //            car_id = Convert.ToInt32(dbDataRecord["car_id"]);
            //        }
            //    }
            //    AZSTableReader.Close();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

            return car_id;
        }

        public string FindCardNumByCarID(int id)
        {
            string cardnum = String.Empty;
            //try
            //{
            //    dbc.OpenConnection();
            //    var queryCommand = new SqlCommand("SELECT cardnum FROM \"AZS\".\"Car\" WHERE car_id = @Car_id");
            //    queryCommand.Parameters.AddWithValue("@Car_id", id);
            //    var AZSTableReader = queryCommand.ExecuteReader();
            //    if (AZSTableReader.HasRows)
            //    {
            //        foreach (DbDataRecord dbDataRecord in AZSTableReader)
            //        {
            //            cardnum = dbDataRecord["cardnum"].ToString();
            //        }
            //    }
            //    AZSTableReader.Close();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

            return cardnum;
        }


        public List<string> GetCardNumList()
        {
            List<string> comboBoxElements = new List<string>();

            //try
            //{
            //    dbc.OpenConnection();
            //    var queryCommand = new SqlCommand("SELECT DISTINCT cardnum FROM \"AZS\".\"Car\"");
            //    var AZSTableReader = queryCommand.ExecuteReader();
            //    if (AZSTableReader.HasRows)
            //    {
            //        foreach (DbDataRecord dbDataRecord in AZSTableReader)
            //        {
            //            comboBoxElements.Add(dbDataRecord["cardnum"].ToString());
            //        }
            //    }
            //    AZSTableReader.Close();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

            return comboBoxElements;
        }

        public void AddToCarTable(Client car)
        {
            //try
            //{
            //    dbc.OpenConnection();

            //    var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Car\"(carmark, cardnum)" +
            //                                      "VALUES(@carmark, @cardnum)");
            //    queryCommand.Parameters.AddWithValue("@carmark", car.GetCarMark());
            //    queryCommand.Parameters.AddWithValue("@cardnum", car.GetCardNum());

            //    queryCommand.ExecuteNonQuery();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

        }
    }
}