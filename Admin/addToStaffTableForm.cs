using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Repositories;
using Queries.Validators;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToStaffTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridView dgv;
        private int station_id;
        private string surname, name, gender, function;
        private DateTime birthdate;

  

        private void addToStaffTableForm_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("муж");
            cbGender.Items.Add("жен");
            try
            {
                cbStationList.Visible = false;
                label2.Visible = false;
                ComboBoxStaffFiller comboBoxStaffFiller = new ComboBoxStaffFiller(cbOrgList, factory);
                comboBoxStaffFiller.СbOrgFill();
            }
            catch (Exception) { MessageBox.Show("Ошибка базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbOrgList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cbOrgList.SelectedIndex != -1)
                {
                    cbStationList.Items.Clear();
                    cbStationList.Visible = true;
                    label2.Visible = true;
                    ComboBoxStaffFiller comboBoxStaffFiller = new ComboBoxStaffFiller(cbStationList, factory);
                    comboBoxStaffFiller.СbStationFill(cbOrgList.Text);
                }
            }
            catch (Exception) { MessageBox.Show("Ошибка базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    station_id = factory.GetStationRepository().FindStationIDByLocation(cbStationList.Text);
                } catch(Exception) { station_id = -1; }
                if (station_id == 0)
                {
                    station_id = -1;
                }
                surname = tbSurname.Text;
                name = tbName.Text;
                if (cbGender.SelectedIndex != -1)
                {
                    gender = Convert.ToString(cbGender.Text);
                }
                else gender = String.Empty;
                birthdate = Convert.ToDateTime(birthDatePick.Text);
                function = tbFunction.Text;
                int salary;
                bool checkStorageCap = Int32.TryParse(tbSalary.Text, out salary);
                if (!checkStorageCap)
                {
                    salary = -1;
                }
                Worker wk = new Worker();
                wk.workerSet(station_id, surname, name, gender, birthdate, function, salary);
                StaffController staffController = new StaffController(dgv, factory);
                if (staffController.AddToTable(wk))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
      
        public AddToStaffTableForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
