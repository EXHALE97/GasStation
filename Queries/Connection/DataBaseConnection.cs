using System;
using System.Data.SqlClient;

namespace Queries.Connection
{
    public class DataBaseConnection 
    {
        private static SqlConnection _connection;

        public DataBaseConnection(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception) {  }
        }

        public void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception) { }
        }
    }
}
