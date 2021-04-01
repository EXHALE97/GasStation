using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.Controllers
{
    public class LoginController
    {
        private readonly Login login;
        private readonly IRepositoryFactory factory;
        private readonly DataBaseUserValidator dataBaseUserValidator;
        private List<string> errorList;
        private string error;

        public LoginController(Login login, IRepositoryFactory factory)
        {
            this.login = login ?? throw new ArgumentNullException();
            this.factory = factory;
            dataBaseUserValidator = new DataBaseUserValidator();
        }

        public LoginController(IRepositoryFactory factory)
        {
            this.factory = factory;
            dataBaseUserValidator = new DataBaseUserValidator();
        }

        public string TryLogin()
        {
            return factory.GetLoginRepository().LoginToTable(login);
        }

        public string GetDbPasswordByRole(string role)
        {
            var password = string.Empty;
            try
            {
                password = factory.GetLoginRepository().GetRolePass(role);
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return password;
        }

        public bool AddToLoginTable(DBUser dbUser)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = dataBaseUserValidator.CheckAddition(dbUser, out errorList))
                {
                    factory.GetLoginRepository().AddNewDbUser(dbUser);
                }
                else
                {
                    int k = 0;
                    foreach (string str in errorList)
                    {
                        k++;
                        error += "Ошибка №" + k + ": " + str + " \n";
                    }
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }
    }
}
