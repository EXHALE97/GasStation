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

        public List<Accounting> GetAccounting()
        {
            var dgvElements = new List<Accounting>();
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
                        var account = new Accounting();
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

        public List<Accounting> GetAccountingBYStationID(int id)
        {
            var dgvElements = new List<Accounting>();
            var queryResult =
                new SqlCommand($"SELECT * FROM \"AZS\".\"Accounting\" WHERE station_id = {id} ORDER BY accountdate")
                    .ExecuteReader();
            if (queryResult.HasRows)
            {
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    var account = new Accounting();
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
