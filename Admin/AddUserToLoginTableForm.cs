using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AddUserToLoginTableForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly IRepositoryFactory factory;

        public AddUserToLoginTableForm(DataGridViewRow selectedRow, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.factory = factory;
        }

        private void AddToLoginTableForm_Load(object sender, EventArgs e)
        {
            if (selectedRow.Cells["CredId"].Value.ToString() == "-")
            {
                try
                {
                    PasswordTextBox.UseSystemPasswordChar = true;
                    ClientFullNameLabel.Text = factory.GetClientRepository().FindClientById(Convert.ToInt32(selectedRow.Cells["ClientId"].Value));
                }
                catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
            }
            else
            {
                ErrorMessageBox.ShowCustomErrorMessage("Этому пользователю уже был выдан пароль!");
                Close();
            }
        }

        private void AddCredentialsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (new ClientController(factory).SetClientCredentials(Convert.ToInt32(selectedRow.Cells["ClientId"].Value),
                    new Credentials(LoginTextBox.Text, PasswordTextBox.Text, "user")))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowInvalidDataMessage(); }
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void CheckPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !CheckPassCheckBox.Checked;
        }
    }
}
