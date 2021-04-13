using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class LoginController
    {
        private readonly Credentials login;
        private readonly IRepositoryFactory factory;
        private List<string> errorList;
        private string error;

        public LoginController(Credentials login, IRepositoryFactory factory)
        {
            this.login = login ?? throw new ArgumentNullException();
            this.factory = factory;
        }

        public LoginController(IRepositoryFactory factory)
        {
            this.factory = factory;
        }

        public string TryLogin()
        {
            return factory.GetCredentialsRepository().LoginToTable(login);
        }

        public string GetDbPasswordByRole(string role)
        {
            var password = string.Empty;
            try
            {
                password = factory.GetCredentialsRepository().GetRolePass(role);
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

        public bool AddToLoginTable(Credentials dbUser)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag == CredentialsValidator.CheckAddition(dbUser, out errorList))
                {
                    factory.GetCredentialsRepository().AddNewDbUser(dbUser);
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
