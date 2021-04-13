using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class UpdateEmployeeForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly DataGridViewRow updatingRow;
        private readonly Lazy<EmployeeController> employeeController;

        public UpdateEmployeeForm(DataGridViewRow updatingRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            employeeController = new Lazy<EmployeeController>(() => new EmployeeController(dgv, factory));
            this.updatingRow = updatingRow;
            this.factory = factory;
        }

        private void EmployeeSurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyLetters(e);
        }

        private void EmployeeNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyLetters(e);
        }

        private void EmployeeSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyNumbersAndDot(e);
        }

        private void EmployeePositionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyLetters(e);
        }

        private void EmployeeMiddleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyLetters(e);
        }

        private void EmployeePhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyNumbersAndPlus(e);
        }

        private void EmployeeAddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleLettersAndSpace(e);
        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            var credId = updatingRow.Cells["EmployeeConnectedCreds"].Value.ToString();

            EmployeeSurNameTextBox.Text = updatingRow.Cells["EmployeeSurname"].Value.ToString();
            EmployeeNameTextBox.Text = updatingRow.Cells["EmployeeName"].Value.ToString();
            EmployeeMiddleNameTextBox.Text = updatingRow.Cells["EmployeeMiddleName"].Value.ToString();
            EmployeePositionTextBox.Text = updatingRow.Cells["EmployeePosition"].Value.ToString();
            EmployeeBirthdayPicker.Value = Convert.ToDateTime(updatingRow.Cells["EmployeeBirthday"].Value.ToString());
            EmploymentDatePicker.Value = Convert.ToDateTime(updatingRow.Cells["EmploymentDate"].Value.ToString());
            ConctractEndPicker.Value = Convert.ToDateTime(updatingRow.Cells["EmployeeContractEnd"].Value.ToString());
            EmployeeSalaryTextBox.Text = updatingRow.Cells["EmployeeSalary"].Value.ToString();
            EmployeeAddressTextBox.Text = updatingRow.Cells["EmployeeAddress"].Value.ToString();
            EmployeePhoneTextBox.Text = updatingRow.Cells["EmployeePhone"].Value.ToString();
            WorkingRadio.Checked = bool.Parse(updatingRow.Cells["EmployeeIsWorking"].Value.ToString());
            NotWorkingRadio.Checked = !bool.Parse(updatingRow.Cells["EmployeeIsWorking"].Value.ToString());
            employeeController.Value.FillCredentialsLoginsComboBox(EmployeeCredsComboBox, credId == "-" ? 0 : int.Parse(credId));
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var credSelected = EmployeeCredsComboBox.SelectedItem.ToString();
                if (employeeController.Value.UpdateTable(int.Parse(updatingRow.Cells["EmployeeId"].Value.ToString()), 
                    new Employee(credSelected == "-" ? 0 : factory.GetCredentialsRepository().GetCredentialsIdByLogin(credSelected), EmployeeSurNameTextBox.Text, 
                        EmployeeNameTextBox.Text, EmployeeMiddleNameTextBox.Text, EmployeePositionTextBox.Text, EmployeeBirthdayPicker.Value, EmploymentDatePicker.Value, 
                        ConctractEndPicker.Value, double.Parse(EmployeeSalaryTextBox.Text), EmployeeAddressTextBox.Text, EmployeePhoneTextBox.Text, WorkingRadio.Checked)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void CancelUpdateButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleLettersAndSpace(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HandleOnlyLetters(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HandleOnlyNumbersAndPlus(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 43 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HandleOnlyNumbersAndDot(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
