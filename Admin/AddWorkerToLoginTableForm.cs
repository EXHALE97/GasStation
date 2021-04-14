using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AddWorkerToLoginTableForm : Form
    {
        private readonly DataGridViewRow selectedRow;
        private readonly IRepositoryFactory factory;

        public AddWorkerToLoginTableForm(DataGridViewRow selectedRow, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.factory = factory;
        }

        private void AddToLoginTableForm_Load(object sender, EventArgs e)
        {
            if (selectedRow.Cells["EmployeeConnectedCreds"].Value.ToString() == "-")
            {
                try
                {
                    UserPasswordTextBox.UseSystemPasswordChar = true;
                    NameLabel.Text = factory.GetEmployeeRepository().FindEmployeeById(Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value));
                }
                catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
            }
            else
            {
                ErrorMessageBox.ShowCustomErrorMessage("Этому работнику уже был выдан пароль!");
                Close();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (new EmployeeController(factory).SetEmployeeCredentials(Convert.ToInt32(selectedRow.Cells["EmployeeId"].Value),
                    new Credentials(UserLoginTextBox.Text, UserPasswordTextBox.Text, "worker")))
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
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
                e.Handled = true;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserPasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
