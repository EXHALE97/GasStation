using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private DataBaseConnection dbc;

        public AccountRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }

        public List<Account> GetAccounting()
        {
            List<Account> dgvElements = new List<Account>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT  * FROM \"AZS\".\"Accounting\" ORDER BY accountdate");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Account account = new Account();
                        account.accountSet(Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["accountrole"].ToString(),
                            dbDataRecord["fuelaccounttype"].ToString(), Convert.ToInt32(dbDataRecord["fuelaccountamount"]),
                            Convert.ToDateTime(dbDataRecord["accountdate"].ToString()));
                        dgvElements.Add(account);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dgvElements;
        }

        public List<Account> GetAccountingBYStationID(int id)
        {
            List<Account> dgvElements = new List<Account>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Accounting\" WHERE station_id = @Station_id ORDER BY accountdate");
                queryCommand.Parameters.AddWithValue("@Station_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Account account = new Account();
                        account.accountSet(Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["accountrole"].ToString(),
                            dbDataRecord["fuelaccounttype"].ToString(), Convert.ToInt32(dbDataRecord["fuelaccountamount"]),
                            Convert.ToDateTime(dbDataRecord["accountdate"].ToString()));
                        dgvElements.Add(account);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dgvElements;
        }
    }
}
