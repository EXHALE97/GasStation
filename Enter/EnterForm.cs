using System;
using System.Windows.Forms;
using System.Configuration;
using Queries.Entities;
using User;
using Admin;
using Queries.Connection;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.MessageBox;
using Worker;


namespace Enter
{
    public partial class EnterForm : Form //форма логина
    {
        public EnterForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Credentials logUser;
            try
            {
                logUser = new Credentials(LoginTextBox.Text, PasswordTextBox.Text);
            }
            catch (Exception)
            {
                ErrorMessageBox.ShowInvalidDataMessage();
                return;
            }

            try
            {
                logUser.Role = new CredentialsController(new RepositoryFactory(
                    new DataBaseConnection(ConfigurationManager.ConnectionStrings["Admin"].ToString()))).TryLogin(logUser);

                if (logUser.Role == string.Empty)
                    MessageBox.Show("Пользователь не найден!");
                else
                {
                    EnterRole(logUser.Role, logUser.Login);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входа!");
            }
        }

        private void EnterRole(string role, string login)
        {
            switch (role)
            {
                case "worker":
                    var factory = new RepositoryFactory(
                        new DataBaseConnection(ConfigurationManager.ConnectionStrings["Worker"].ToString()));
                    var workerForm = new WorkerForm(factory.GetCredentialsRepository().GetCredentialsIdByLogin(login), factory);
                    Hide();
                    workerForm.ShowDialog();
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();
                    Show();
                    break;
                case "admin":
                    var adminForm = new AdminForm(new RepositoryFactory(
                        new DataBaseConnection(ConfigurationManager.ConnectionStrings["Admin"].ToString())));
                    Hide();
                    adminForm.ShowDialog();
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();
                    Show();
                    break;
                case "user":
                    var userForm = new UserForm(login,
                        new RepositoryFactory(
                            new DataBaseConnection(ConfigurationManager.ConnectionStrings["User"].ToString())));
                    Hide();
                    userForm.ShowDialog();
                    LoginTextBox.Clear();
                    PasswordTextBox.Clear();
                    Show();
                    break;
            }
        }
    }
}