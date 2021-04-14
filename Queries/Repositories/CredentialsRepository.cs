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
                    role = dbDataRecord["role"].ToString();
                }

                return role;
            });
        }

        public int AddNewCredentials(Credentials dbUser)
        {
            return ExecuteSqlCommand($"EXEC InsertCredentials '{dbUser.Login}', '{dbUser.Password}', '{dbUser.Role}'", queryResult =>
            {
                var id = 0;
                if (!queryResult.HasRows) return id;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    id = int.Parse(dbDataRecord[0].ToString());
                }

                return id;
            });
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

        public string GetCredentialsLoginById(int id)
        {
            return ExecuteSqlCommand($"EXEC GetCredentialsById '{id}'", queryResult =>
            {
                var login = string.Empty;
                if (!queryResult.HasRows) return login;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    login = dbDataRecord["login"].ToString();
                }

                return login;
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
    }
}
