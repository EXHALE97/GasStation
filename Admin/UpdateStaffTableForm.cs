using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Interfaces;

namespace Admin
{
    public partial class UpdateStaffTableForm : Form
    {
        private IRepositoryFactory factory;
        private string surname, name, function;
        private DataGridViewRow updateRow;
        private DataGridView dgv;

        public UpdateStaffTableForm(DataGridViewRow updateRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.updateRow = updateRow;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void updateStaffTableForm_Load(object sender, EventArgs e)
        {
            tbSurname.Text = updateRow.Cells["surname"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbName.Text = updateRow.Cells["name"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbFunction.Text = updateRow.Cells["function"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbFunction.Text = updateRow.Cells["function"].Value.ToString().Trim().Replace(" ", string.Empty);
            tbSalary.Text = updateRow.Cells["salary"].Value.ToString().Trim().Replace(" ", string.Empty);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                surname = tbSurname.Text;
                name = tbName.Text;
                function = tbFunction.Text;
                int salary;
                bool checkSalary = Int32.TryParse(tbSalary.Text, out salary);
                if (!checkSalary)
                {
                    salary = -1;
                }
                Worker wk = new Worker();
                wk.workerSet(surname, name, function, salary);
                var cell = dgv[0, dgv.CurrentRow.Index];
                int id = Convert.ToInt32(cell.Value);
                StaffController staffController = new StaffController(dgv, factory);
                if (staffController.UpdateTable(id, wk))
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
    }
}
