using System;
using System.Windows.Forms;
using System.Configuration;
using Queries;
using Queries.Entities;
using User;
using Admin;
using Queries.Connection;
using Queries.Controllers;
using Queries.Factory;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text, password = tbPassword.Text;
            Credentials logUser;
            try
            {
                //logUser = new Login(login.Trim().Replace(" ", string.Empty),
                //    SecurityCrypt.MD5(password).Trim().Replace(" ", string.Empty));
                logUser = new Credentials(login.Trim().Replace(" ", string.Empty),
                    password.Trim().Replace(" ", string.Empty));
            }
            catch (Exception)
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var loginController = new LoginController(logUser,
                    new RepositoryFactory(
                        new DataBaseConnection(ConfigurationManager.ConnectionStrings["Admin"].ToString())));
                var role = loginController.TryLogin();

                if (role == string.Empty)
                    MessageBox.Show("Пользователь не найден!");
                role = role.Trim().Replace(" ", string.Empty);
                //rolePass = SecurityCrypt.DESDecrypt(loginController.GetDbPasswordByRole(role), SecurityConst.cryptKey);
                EnterRole(role, login);
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
                    var workerForm = new WorkerForm(Convert.ToInt32(login),
                        new RepositoryFactory(
                            new DataBaseConnection(ConfigurationManager.ConnectionStrings["Worker"].ToString())));
                    Hide();
                    workerForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "admin":
                    var adminForm = new AdminForm(new RepositoryFactory(
                        new DataBaseConnection(ConfigurationManager.ConnectionStrings["Admin"].ToString())));
                    Hide();
                    adminForm.ShowDialog();
                    tbLogin.Clear();
                    tbPassword.Clear();
                    Show();
                    break;
                case "user":
                    var userForm = new UserForm(login,
                        new RepositoryFactory(
                            new DataBaseConnection(ConfigurationManager.ConnectionStrings["User"].ToString())));
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