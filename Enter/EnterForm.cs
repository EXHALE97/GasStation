using System;
using System.Windows.Forms;
using System.Configuration;
using Queries;
using Queries.Interfaces;
using Queries.Validators;
using Queries.Entities;
using Queries.Security;
using User;
using Admin;
using Queries.Connection;
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
            DataBaseConnection dbc = null;
            string Login = String.Empty, Password = String.Empty, role = String.Empty, rolePass = String.Empty;
            Login login = null;
            try
            {
                Login = tbLogin.Text.ToString();
                Password = tbPassword.Text.ToString();
                login = new Login();
                login.setLogin(Login.Trim().Replace(" ", string.Empty), SecurityCrypt.MD5(Password).Trim().Replace(" ", string.Empty));
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            try
            {
                var dataBaseConnection = new DataBaseConnection(ConfigurationManager.ConnectionStrings["GasStation"].ToString());
                RepositoryFactory repLoginFactory = new RepositoryFactory(dataBaseConnection);
                LoginController lc = new LoginController(login, repLoginFactory);
                role = lc.TryLogin();
                if (role == String.Empty)
                MessageBox.Show("Пользователь не найден!");
                role = role.Trim().Replace(" ", string.Empty);
                rolePass = SecurityCrypt.DESDecrypt(lc.GetDBPassWordByRole(role), SecurityConst.cryptKey);
                EnterRole(role, Login, rolePass);
            }
            catch (Exception) { MessageBox.Show("Ошибка входа!"); }
        }

        private void EnterRole(string role, string Login, string rolePass)
        {
            switch (role)
            {
                case "worker":
                    NpgsqlConnection workerConn = new NpgsqlConnection("Server = 127.0.0.1; Port = 5432; User Id = worker; Password =" + rolePass + "; Database = AZS");
                    DataBaseConnection workerDbc = new DataBaseConnection(workerConn);
                    IRepositoryFactory repWorkerFactory = new RepositoryFactory(workerDbc);
                    WorkerForm workerForm = new WorkerForm(Convert.ToInt32(Login), repWorkerFactory);
                    Hide();
                    workerForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "admin":
                    NpgsqlConnection adminConn = new NpgsqlConnection("Server = 127.0.0.1; Port = 5432; User Id = admin; Password =" + rolePass + "; Database = AZS");
                    DataBaseConnection adminDbc = new DataBaseConnection(adminConn);
                    IRepositoryFactory repAdminFactory = new RepositoryFactory(adminDbc);
                    AdminForm adminForm = new AdminForm(repAdminFactory);
                    Hide();
                    adminForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "user":
                    NpgsqlConnection userConn = new NpgsqlConnection("Server = 127.0.0.1; Port = 5432; User Id = user; Password =" + rolePass + "; Database = AZS");
                    DataBaseConnection userDbc = new DataBaseConnection(userConn);
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