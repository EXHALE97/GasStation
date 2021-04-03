using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Interfaces;
using Queries.Entities;

namespace Admin
{
    public partial class AddUserToLoginTableForm : Form
    {
        private DataGridViewRow row;
        private IRepositoryFactory factory;

        public AddUserToLoginTableForm(DataGridViewRow row, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.row = row;
            this.factory = factory;
        }

        private void AddToLoginTableForm_Load(object sender, EventArgs e)
        {
            if (!factory.GetLoginRepository().IsThereCurrentCredentialsInTable(row.Cells["cardnum"].Value.ToString().Trim().Replace(" ", string.Empty)))
            {
                try
                {
                    lbName.Text = row.Cells["cardnum"].Value.ToString().Trim().Replace(" ", string.Empty);
                    tbPass.UseSystemPasswordChar = true;
                }
                catch (Exception) { }
            }
            else
            {
                MessageBox.Show("Этому пользователю уже был выдан пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string passWord = String.Empty;
            try
            {
                passWord = tbPass.Text.ToString();
                var nUser =
                    new Credentials(row.Cells["cardnum"].Value.ToString().Trim().Replace(" ", string.Empty),
                        passWord.Trim().Replace(" ", string.Empty), "user");
                var lc = new LoginController(factory);
                if (lc.AddToLoginTable(nUser))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                tbPass.UseSystemPasswordChar = false;
            }
            else tbPass.UseSystemPasswordChar = true;
        }
    }
}
