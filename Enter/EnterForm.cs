using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Queries;
using Queries.Interfaces;
using Queries.Validators;
using Queries.Entities;
using Queries.Security;
using User;
using Admin;
using Queries.Connection;
using Queries.Controllers;
using Worker;


namespace Enter
{
    public partial class EnterForm : Form //форма логина
    {
        public EnterForm()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnAdminLog_Click(object sender, EventArgs e)
        {
            Hide();
            new AdminForm(new RepositoryFactory(
                new DataBaseConnection(ConfigurationManager.ConnectionStrings["GasStation"].ToString()))).ShowDialog();
            Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text, password = tbPassword.Text, role = string.Empty, rolePass = string.Empty;
            var loginEntity = new Login();
            try
            {
                loginEntity.setLogin(login.Trim().Replace(" ", string.Empty), SecurityCrypt.MD5(password).Trim().Replace(" ", string.Empty));
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
                var repLoginFactory = new RepositoryFactory(new DataBaseConnection(ConfigurationManager.ConnectionStrings["GasStation"].ToString()));
                var loginController = new LoginController(loginEntity, repLoginFactory);
                role = loginController.TryLogin();
                if (role == String.Empty)
                    MessageBox.Show("Пользователь не найден!");
                role = role.Trim().Replace(" ", string.Empty);
                rolePass = SecurityCrypt.DESDecrypt(loginController.GetDBPassWordByRole(role), SecurityConst.cryptKey);
                EnterRole(role, login, rolePass);
            }
            catch (Exception) { MessageBox.Show("Ошибка входа!"); }
        }

        private void EnterRole(string role, string Login, string rolePass)
        {
            switch (role)
            {
                case "worker":
                    DataBaseConnection workerDbc = new DataBaseConnection("Server = 127.0.0.1; Port = 5432; User Id = worker; Password =" + rolePass + "; Database = AZS");
                    IRepositoryFactory repWorkerFactory = new RepositoryFactory(workerDbc);
                    WorkerForm workerForm = new WorkerForm(Convert.ToInt32(Login), repWorkerFactory);
                    Hide();
                    workerForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "admin":
                    DataBaseConnection adminDbc = new DataBaseConnection("Server = 127.0.0.1; Port = 5432; User Id = admin; Password =" + rolePass + "; Database = AZS");
                    IRepositoryFactory repAdminFactory = new RepositoryFactory(adminDbc);
                    AdminForm adminForm = new AdminForm(repAdminFactory);
                    Hide();
                    adminForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "user":
                    DataBaseConnection userDbc = new DataBaseConnection("Server = 127.0.0.1; Port = 5432; User Id = user; Password =" + rolePass + "; Database = AZS");
                    IRepositoryFactory repUserFactory = new RepositoryFactory(userDbc);
                    UserForm userForm = new UserForm(Login, repUserFactory);
                    Hide();
                    userForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}