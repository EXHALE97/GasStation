using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
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
            return ExecuteSqlCommand($"EXEC GetCredentialsRole '{login.Login}', '{login.Password}'", queryResult =>
            {
                var role = string.Empty;

                if (!queryResult.HasRows) return role;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    role = dbDataRecord["Role"].ToString();
                }

                return role;
            });
        }

        public void AddNewDbUser(Credentials dbUser)
        {
            ExecuteSqlNonQueryCommand($"INSERT INTO Credentials VALUES('{dbUser.Login}', '{dbUser.Password}', '{dbUser.Role}')");
        }

        public bool IsThereCurrentCredentialsInTable(string login)
        {
            return ExecuteSqlCommand($"EXEC GetCredentialsByLogin '{login}'", queryResult => queryResult.HasRows);
        }

        public int GetCredentialsIdByLogin(string login)
        {
            return ExecuteSqlCommand($"EXEC GetCredentialsByLogin '{login}'", queryResult =>
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

        public string GetRolePass(string role)
        {
            return ExecuteSqlCommand($"SELECT Password FROM Credentials WHERE Role = {role}", queryResult =>
            {
                var password = string.Empty;
                if (!queryResult.HasRows) return password;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    password = dbDataRecord["Password"].ToString();
                }

                return password;
            });
        }

        public IList<string> GetUserLogins()
        {
            return ExecuteSqlCommand("EXEC GetCredentialsLogins", queryResult =>
            {
                var logins = new List<string>();
                if (!queryResult.HasRows) return null;
                logins.AddRange(from DbDataRecord dbDataRecord in queryResult select dbDataRecord[0].ToString());
                return logins;
            });
        }

        public void DeleteStaffFromLoginTable(string id)
        {
            ExecuteSqlNonQueryCommand($"DELETE FROM Credentials WHERE Login = {id}");
        }
    }
}
