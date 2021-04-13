using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Interfaces;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var passWord = string.Empty;
            try
            {
                passWord = UserPasswordTextBox.Text.ToString();
                var nWorker = new Credentials(selectedRow.Cells["staff_id"].Value.ToString(), passWord.ToString(), "worker");
                var loginController = new LoginController(factory);
                if (loginController.AddToLoginTable(nWorker))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            UserPasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
