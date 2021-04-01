using System.Data.SqlClient;
using Queries.Connection;

namespace Queries.Repositories
{
    public abstract class BaseRepository
    {
        protected DataBaseConnection DataBaseConnection;

        protected SqlDataReader ExecuteSqlCommand(string command)
        {
            try
            {
                DataBaseConnection.OpenConnection();
                return new SqlCommand(command, DataBaseConnection.GetConnection()).ExecuteReader();
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }
        }

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