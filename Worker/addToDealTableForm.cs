using System;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Controllers;
using Queries.Factory;
using Queries.Interfaces;
using Queries.Support.ComboBox;

namespace Worker
{
    public partial class AddToDealTableForm : Form
    {
        private DataGridView dgv;
        private IRepositoryFactory factory;
        private int ID;
        private string fueltype, cardnum;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        DateTime dealdate;

        public AddToDealTableForm(int ID, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
            this.ID = ID;
        }

        private void checkNow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNow.Checked)
            {
                tbHours.Visible = false;
                tbMinutes.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            if (!checkNow.Checked)
            {
                tbHours.Visible = true;
                tbMinutes.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFuelType.SelectedIndex != -1)
                {
                    fueltype = Convert.ToString(cbFuelType.Text);
                }
                else fueltype = String.Empty;
                int fuelamount;
                bool checkFuelAmount = Int32.TryParse(tbFuelamount.Text, out fuelamount);
                if (!checkFuelAmount)
                {
                    fuelamount = -1;
                }
                if (cbCardNum.SelectedIndex != -1)
                {
                    cardnum = Convert.ToString(cbCardNum.Text);
                    cardnum = cardnum.Trim().Replace(" ", string.Empty);
                }
                else cardnum = String.Empty;
                int dealprice;
                bool checkDealPrice = Int32.TryParse(tbDealPrice.Text, out dealprice);
                if(!checkDealPrice)
                {
                    dealprice = -1;
                }
                dealdate = Convert.ToDateTime(dealDatePick.Text);

                if (checkNow.Checked)
                {
                    dealdate = DateTime.Now;
                }
                if (!checkNow.Checked && (tbHours.Text != String.Empty || tbMinutes.Text != String.Empty))
                {
                    int hours, minutes;
                    bool checkHours = Int32.TryParse(tbHours.Text, out hours);
                    bool checkMinutes = Int32.TryParse(tbMinutes.Text, out minutes);
                    if (checkHours != false && checkMinutes != false)
                    {
                        dealdate = dealdate.AddHours(hours);
                        dealdate = dealdate.AddMinutes(minutes);
                    }
                    else
                    {
                        dealdate = DateTime.Now;
                        MessageBox.Show("Неверный формат времени! Выставлено текущее время!");
                    }
                }

                //Deal deal = new Deal();
                //deal.dealSet(0, factory.GetClientRepository().FindCarIDByCardnum(cardnum), ID, fueltype, fuelamount, dealprice, dealdate);
                //DealController dealController = new DealController(dgv, factory);
                //if (dealController.AddToTable(deal))
                //{
                //    MessageBox.Show("Операция выполнена успешно!");
                //    Close();
                //}
            }
            catch (Exception pe) { MessageBox.Show(pe.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbFuelamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbDealPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dealDatePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbDealPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void updateDealTableForm_Load(object sender, EventArgs e)
        {
            new ComboBoxFiller(factory).FillCardNumbers(cbCardNum);
        }
    }
}
