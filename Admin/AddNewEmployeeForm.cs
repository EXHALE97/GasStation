using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;

namespace Admin
{
    public partial class AddNewEmployeeForm : Form
    {
        private readonly Lazy<EmployeeController> employeeController;

        public AddNewEmployeeForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            employeeController = new Lazy<EmployeeController>(() => new EmployeeController(dgv, factory));
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeController.Value.AddToTable(new Employee(EmployeeSurnameTextBox.Text, EmployeeNameTextBox.Text, EmployeeMiddleNameTextBox.Text,
                    EmployeePositionTextBox.Text, EmployeeBirthDatePicker.Value, EmploymentDatePicker.Value, ContractEndDatePicker.Value,
                    double.Parse(EmployeeSalaryTextBox.Text), EmployeeAddressTextBox.Text, EmployeePhoneTextBox.Text, WorkingRadio.Checked)))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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

        private void CancelAddingButton_Click(object sender, EventArgs e)
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
