using System.Data.SqlClient;
using Queries.Connection;

namespace Queries.Repositories
{
    public abstract class BaseRepository
    {
        protected DataBaseConnection DataBaseConnection;

        protected int ExecuteSqlNonQueryCommand(string command)
        {
            try
            {
                DataBaseConnection.OpenConnection();
                return new SqlCommand(command, DataBaseConnection.GetConnection()).ExecuteNonQuery();
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }
        }
    }
}