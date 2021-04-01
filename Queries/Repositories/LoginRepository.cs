using System.Data.Common;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public string LoginToTable(Login login)
        {
            var role = string.Empty;
            var queryResult =
                ExecuteSqlCommand(
                    $"SELECT * FROM \"Login\".\"LoginTable\" WHERE login = {login.GetLogin()} AND password = {login.GetPassword()}");

            if (!queryResult.HasRows) return role;
            foreach (DbDataRecord dbDataRecord in queryResult)
            {
                role = dbDataRecord["role"].ToString();
            }

            return role;
        }

        public void AddNewDbUser(DBUser dbUser)
        {
            ExecuteSqlNonQueryCommand("INSERT INTO \"Login\".\"LoginTable\"(Login, Password, Role)" +
                                      $"VALUES({dbUser.GetDBUserLogin()}, {dbUser.GetDBUserPass()}, {dbUser.GetDBUserRole()})");
        }

        public bool CheckLoginExistence(string login)
        {
            return ExecuteSqlCommand($"SELECT * FROM \"Login\".\"LoginTable\" WHERE login = {login}").HasRows;
        }      

        public string GetRolePass(string role)
        {
            var passWord = string.Empty;
            var queryResult =
                ExecuteSqlCommand($"SELECT Password FROM \"Login\".\"RoleTable\" WHERE Role = {role}");

            if (!queryResult.HasRows) return passWord;
            foreach (DbDataRecord dbDataRecord in queryResult)
            {
                passWord = dbDataRecord["Password"].ToString();
            }
            queryResult.Close();

            return passWord;

        }

        public void DeleteStaffFromLoginTable(string id)
        {
            ExecuteSqlNonQueryCommand($"DELETE FROM \"Login\".\"LoginTable\"  WHERE login = {id}");
        }
    }
}
