using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public List<Account> GetAccounting()
        {
            var dgvElements = new List<Account>();
            try
            {
                DataBaseConnection.OpenConnection();
                var queryResult =
                    new SqlCommand($"SELECT * FROM \"AZS\".\"Accounting\" ORDER BY accountdate",
                        DataBaseConnection.GetConnection()).ExecuteReader();
                if (queryResult.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in queryResult)
                    {
                        var account = new Account();
                        account.accountSet(Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["accountrole"].ToString(),
                            dbDataRecord["fuelaccounttype"].ToString(), Convert.ToInt32(dbDataRecord["fuelaccountamount"]),
                            Convert.ToDateTime(dbDataRecord["accountdate"].ToString()));
                        dgvElements.Add(account);
                    }
                }
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }

            return dgvElements;
        }

        public List<Account> GetAccountingBYStationID(int id)
        {
            var dgvElements = new List<Account>();
            var queryResult =
                new SqlCommand($"SELECT * FROM \"AZS\".\"Accounting\" WHERE station_id = {id} ORDER BY accountdate")
                    .ExecuteReader();
            if (queryResult.HasRows)
            {
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    var account = new Account();
                    account.accountSet(Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["accountrole"].ToString(),
                        dbDataRecord["fuelaccounttype"].ToString(), Convert.ToInt32(dbDataRecord["fuelaccountamount"]),
                        Convert.ToDateTime(dbDataRecord["accountdate"].ToString()));
                    dgvElements.Add(account);
                }
            }
            queryResult.Close();
            return dgvElements;
        }
    }
}
