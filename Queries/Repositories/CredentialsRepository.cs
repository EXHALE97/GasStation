using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class CredentialsRepository : BaseRepository, ICredentialsRepository
    {
        public CredentialsRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public string LoginToTable(Credentials login)
        {
            var role = string.Empty;
            try
            {
                DataBaseConnection.OpenConnection();
                var queryResult =
                    new SqlCommand(
                        $"SELECT * FROM Credentials WHERE login = '{login.login}' AND password = '{login.password}'",
                        DataBaseConnection.GetConnection()).ExecuteReader();
                if (!queryResult.HasRows) return role;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    role = dbDataRecord["role"].ToString();
                }
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }

            return role;
        }

        public void AddNewDbUser(Credentials dbUser)
        {
            ExecuteSqlNonQueryCommand($"INSERT INTO Credentials VALUES('{dbUser.login}', '{dbUser.password}', '{dbUser.role}')");
        }

        public bool IsThereCurrentCredentialsInTable(string login)
        {
            try
            {
                DataBaseConnection.OpenConnection();
                var queryResult =
                    new SqlCommand($"SELECT * FROM Credentials WHERE login = {login}",
                        DataBaseConnection.GetConnection()).ExecuteReader();
                return queryResult.HasRows;
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }
        }      

        public string GetRolePass(string role)
        {
            var password = string.Empty;
            try
            {
                DataBaseConnection.OpenConnection();
                var queryResult =
                    new SqlCommand($"SELECT password FROM Credentials WHERE role = {role}",
                        DataBaseConnection.GetConnection()).ExecuteReader();
                if (!queryResult.HasRows) return password;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    password = dbDataRecord["password"].ToString();
                }
            }
            finally
            {
                DataBaseConnection.CloseConnection();
            }

            return password;
        }

        public void DeleteStaffFromLoginTable(string id)
        {
            ExecuteSqlNonQueryCommand($"DELETE FROM Credentials WHERE login = {id}");
        }
    }
}
