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

        public List<int> GetActivatedClientCards()
        {
            return ExecuteSqlCommand("EXEC GetActivatedClientCards", queryResult =>
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

        public string GetClientFullNameById(int id)
        {
            return ExecuteSqlCommand($"SELECT dbo.GetClientFullName({id})", queryResult =>
            {
                var fullName = string.Empty;
                if (!queryResult.HasRows) return fullName;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    fullName = dbDataRecord[0].ToString();
                }

                return fullName;
            });
        }

        public int GetDiscountPercentForClient(int clientCardId)
        {
            return ExecuteSqlCommand($"EXEC GetClientByClientCardId {clientCardId}", queryResult =>
            {
                var discount = 0;
                if (!queryResult.HasRows) return discount;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    discount = int.Parse(dbDataRecord["discount_percent"].ToString());
                }

                return discount;
            });
        }

        public void SetClientCredentials(int clientId, Credentials credentials)
        {
            ExecuteSqlNonQueryCommand(
                $"EXEC InsertCredentialsAndConnectToClient '{clientId}', '{credentials.Login}', '{credentials.Password}', '{credentials.Role}'");
        }

        public int GetClientIdByCardId(int clientCardId)
        {
            return ExecuteSqlCommand($"EXEC GetClientByClientCardId {clientCardId}", queryResult =>
            {
                var id = 0;
                if (!queryResult.HasRows) return id;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    id = int.Parse(dbDataRecord["id"].ToString());
                }

                return id;
            });
        }

        public int GetClientIdByCredId(int credId)
        {
            return ExecuteSqlCommand($"EXEC GetClientIdByCredId {credId}", queryResult =>
            {
                var id = 0;
                if (!queryResult.HasRows) return id;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    id = int.Parse(dbDataRecord["id"].ToString());
                }

                return id;
            });
        }

    }
}
