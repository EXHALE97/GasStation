using System.Data.SqlClient;

namespace Queries.Connection
{
    public class DataBaseConnection 
    {
        private readonly SqlConnection connection;

        public DataBaseConnection(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
