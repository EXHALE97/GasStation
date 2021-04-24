using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AddNewAdminForm : Form
    {
        private readonly IRepositoryFactory factory;

        public AddNewAdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            AdminPasswordTextBox.UseSystemPasswordChar = true;
        }

        private void AddAdminButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (factory.GetCredentialsRepository().GetCredentialsIdCountByLogin(AdminLoginTextBox.Text) != 0)
                {
                    if (new CredentialsController(factory).AddToLoginTable(new Credentials(AdminLoginTextBox.Text, AdminPasswordTextBox.Text, "admin")))
                    {
                        SuccessMessageBox.ShowSuccessBox();
                        Close();
                    }
                }
                else
                {
                    ErrorMessageBox.ShowCustomErrorMessage("Администратор с таким именем уже существует!");
                }
            }
            catch (Exception) { ErrorMessageBox.ShowInvalidDataMessage(); }
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AdminPasswordTextBox.UseSystemPasswordChar = !CheckPasswordCheckBox.Checked;
        }
    }
}
