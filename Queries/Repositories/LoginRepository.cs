using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"Login\".\"LoginTable\" WHERE login = @Login AND password = @Password", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Login", login.GetLogin());
                queryCommand.Parameters.AddWithValue("@Password", login.GetPassword());
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        role = dbDataRecord["role"].ToString();
                    }
                }

            }
            catch (PostgresException pe)
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
                
                NpgsqlCommand queryCommand = new NpgsqlCommand("INSERT INTO \"Login\".\"LoginTable\"(Login, Password, Role)" +
                    "VALUES(@Login, @Pass, @Role)", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Login", dbUser.GetDBUserLogin());
                queryCommand.Parameters.AddWithValue("@Pass", SecurityCrypt.MD5((dbUser.GetDBUserPass())));
                queryCommand.Parameters.AddWithValue("@Role", dbUser.GetDBUserRole());
                queryCommand.ExecuteNonQuery();
            }
            catch (PostgresException pe)
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

                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"Login\".\"LoginTable\" WHERE login = @Login", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Login", login);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    checkFlag = true;
                }
                else checkFlag = false;
            }
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT Password FROM \"Login\".\"RoleTable\" WHERE Role = @Role", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Role", role);

                NpgsqlDataReader passWordSearch = queryCommand.ExecuteReader();
                if (passWordSearch.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in passWordSearch)
                    {
                        passWord = dbDataRecord["Password"].ToString();
                    }
                    passWordSearch.Close();
                }
            }
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("DELETE FROM \"Login\".\"LoginTable\"  WHERE login = @Login", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Login", id);
                queryCommand.ExecuteNonQuery();

            }
            catch (PostgresException)
            { }
            finally { dbc.CloseConnection(); }

        }
    }
}
