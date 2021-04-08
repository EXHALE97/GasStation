using System;
using System.Data.SqlClient;
using Queries.Connection;

namespace Queries.Repositories
{
    public abstract class BaseRepository
    {
        protected DataBaseConnection DataBaseConnection;

        protected T ExecuteSqlCommand<T>(string command, Func<SqlDataReader, T> action)
        {
            try
            {
                DataBaseConnection.OpenConnection();
                return action(new SqlCommand(command, DataBaseConnection.GetConnection()).ExecuteReader());
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