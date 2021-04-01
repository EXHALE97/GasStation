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
using Queries.Validators;
using Queries.Interfaces;

namespace Admin
{
    public partial class UpdateDealTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridViewRow updateRow;
        private DataGridView dgv;
        private int hours, minutes;
        private string fuelType, cardNum;
        private DateTime dealDate;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //List<string> errorList = new List<string>();
                if (cbFuelType.SelectedIndex != -1)
                {
                    fuelType = Convert.ToString(cbFuelType.Text);
                }

                int fuelAmount;

                bool checkFuelAmount = Int32.TryParse(tbFuelamount.Text, out fuelAmount);

                if (!checkFuelAmount)
                {
                    fuelAmount = -1;
                }

                if (cbCardNum.SelectedIndex != -1)
                {
                    cardNum = Convert.ToString(cbCardNum.Text).Trim().Replace(" ", string.Empty);
                }

                int dealPrice;

                bool checkDealPrice = Int32.TryParse(tbDealprice.Text, out dealPrice);

                if (!checkDealPrice)
                {
                    dealPrice = -1;
                }


                if (tbHours.Text != String.Empty && tbMinutes.Text != String.Empty)
                {
                    hours = Convert.ToInt32(tbHours.Text);
                    minutes = Convert.ToInt32(tbMinutes.Text);
                    dealDate = Convert.ToDateTime(dealDatePick.Text);
                    dealDate = dealDate.AddHours(hours);
                    dealDate = dealDate.AddMinutes(minutes);
                }
                else
                {
                    dealDate = Convert.ToDateTime(updateRow.Cells["dealdate"].Value);
                }

                Deal deal = new Deal();
                deal.dealSet(factory.GetCarRepository().FindCarIDByCardnum(cardNum), fuelType, fuelAmount, dealPrice, dealDate);
                var cell = dgv[0, dgv.CurrentRow.Index];
                int id = Convert.ToInt32(cell.Value);
                DealController dealController = new DealController(dgv, factory);
                if (dealController.UpdateTable(id, deal))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbFuelamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbDealprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        public UpdateDealTableForm(DataGridViewRow updateRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.updateRow = updateRow;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void updateDealTableForm_Load(object sender, EventArgs e)
        {
            try
            {
                dealDatePick.Value = Convert.ToDateTime(updateRow.Cells["dealdate"].Value);
                tbFuelamount.Text = updateRow.Cells["fuelamount"].Value.ToString();
                tbDealprice.Text = updateRow.Cells["dealprice"].Value.ToString();
                dealDate = Convert.ToDateTime(updateRow.Cells["dealdate"].Value);
                cbFuelType.Items.Add("A92");
                cbFuelType.Items.Add("A95");
                cbFuelType.Items.Add("A95+");
                cbFuelType.SelectedItem = updateRow.Cells["fueltype"].Value.ToString().Trim().Replace(" ", string.Empty);               
                ComboBoxDealFiller comboBoxDealFiller = new ComboBoxDealFiller(cbCardNum, factory);
                comboBoxDealFiller.СbCardnumFill(); 
                cbCardNum.SelectedItem = updateRow.Cells["buyercard"].Value.ToString().Trim().Replace(" ", string.Empty);              
            }
            catch (Exception) { MessageBox.Show("Невозможно выполнить операцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
