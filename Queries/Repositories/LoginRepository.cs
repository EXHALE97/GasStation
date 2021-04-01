using System;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Security;

namespace Queries.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private DataBaseConnection dbc;

        public LoginRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public string LoginToTable(Login login)
        {
            string role = String.Empty;
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"Login\".\"LoginTable\" WHERE login = @Login AND password = @Password");
                queryCommand.Parameters.AddWithValue("@Login", login.GetLogin());
                queryCommand.Parameters.AddWithValue("@Password", login.GetPassword());
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        role = dbDataRecord["role"].ToString();
                    }
                }

            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return role;
        }

        public void AddNewDBUser(DBUser dbUser)
        {            
            try
            {
                dbc.OpenConnection();            
                
                var queryCommand = new SqlCommand("INSERT INTO \"Login\".\"LoginTable\"(Login, Password, Role)" +
                    "VALUES(@Login, @Pass, @Role)");
                queryCommand.Parameters.AddWithValue("@Login", dbUser.GetDBUserLogin());
                queryCommand.Parameters.AddWithValue("@Pass", SecurityCrypt.MD5((dbUser.GetDBUserPass())));
                queryCommand.Parameters.AddWithValue("@Role", dbUser.GetDBUserRole());
                queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }
        }

        public bool CheckLoginExistence(string login)
        {
            bool checkFlag = false;
            try
            {
                dbc.OpenConnection();

                var queryCommand = new SqlCommand("SELECT * FROM \"Login\".\"LoginTable\" WHERE login = @Login");
                queryCommand.Parameters.AddWithValue("@Login", login);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    checkFlag = true;
                }
                else checkFlag = false;
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return checkFlag;
        }      

        public string GetRolePass(string role)
        {
            string passWord = String.Empty;
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT Password FROM \"Login\".\"RoleTable\" WHERE Role = @Role");
                queryCommand.Parameters.AddWithValue("@Role", role);

                var passWordSearch = queryCommand.ExecuteReader();
                if (passWordSearch.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in passWordSearch)
                    {
                        passWord = dbDataRecord["Password"].ToString();
                    }
                    passWordSearch.Close();
                }
            }
            catch (SqlException pe)
            {
                throw pe;          
            }
            finally { dbc.CloseConnection(); }

            return passWord;

        }

        public void DeleteStaffFromLoginTable(string id)
        {
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("DELETE FROM \"Login\".\"LoginTable\"  WHERE login = @Login");
                queryCommand.Parameters.AddWithValue("@Login", id);
                queryCommand.ExecuteNonQuery();

            }
            catch (SqlException)
            { }
            finally { dbc.CloseConnection(); }

        }
    }
}
