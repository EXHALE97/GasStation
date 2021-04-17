using System;
using System.Collections.Generic;
using System.Data.Common;
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
                            dbDataRecord["first_name"].ToString() == string.Empty ? null : dbDataRecord["first_name"].ToString(),
                            dbDataRecord["last_name"].ToString() == string.Empty ? null : dbDataRecord["last_name"].ToString(), 
                            dbDataRecord["middle_name"].ToString() == string.Empty ? null : dbDataRecord["middle_name"].ToString(),
                            int.Parse(dbDataRecord["card_id"].ToString()),
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

        public List<int> GetNonActivatedClientCards()
        {
            return ExecuteSqlCommand("EXEC GetNonActivatedClientCardId", queryResult =>
            {
                var cards = new List<int>();
                if (queryResult.HasRows)
                {
                    cards.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select int.Parse(dbDataRecord["id"].ToString()));
                }

                queryResult.Close();
                return cards;
            });
        }

        public void AddToClientTable(Client client)
        {
            ExecuteSqlNonQueryCommand(
                $"EXEC InsertClient {client.CardId}, {(client.FirstName == null ? "NULL" : $"N'{client.FirstName}'")}, {(client.LastName == null ? "NULL" : $"N'{client.LastName}'")}, {(client.MiddleName == null ? "NULL" : $"N'{client.MiddleName}'")}, {(client.CredId == 0 ? "NULL" : $"{client.CredId}")}");
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

       
    }
}
