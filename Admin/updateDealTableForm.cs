using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.ComboBox;

namespace Admin
{
    public partial class UpdateDealTableForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly DataGridViewRow selectedRow;
        private DataGridView dgv;
        private int hours, minutes;
        private string fuelType, cardNum;
        private DateTime dealDate;

        public UpdateDealTableForm(DataGridViewRow selectedRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            this.factory = factory;
            this.dgv = dgv;
        }

        private void UpdateDealTableForm_Load(object sender, EventArgs e)
        {
            try
            {
                DealDatePicker.Value = Convert.ToDateTime(selectedRow.Cells["dealdate"].Value);
                SupplyTypeAmountTextBox.Text = selectedRow.Cells["fuelamount"].Value.ToString();
                DealPriceTextBox.Text = selectedRow.Cells["dealprice"].Value.ToString();
                dealDate = Convert.ToDateTime(selectedRow.Cells["dealdate"].Value);
                SupplyTypeComboBox.Items.Add("A92");
                SupplyTypeComboBox.Items.Add("A95");
                SupplyTypeComboBox.Items.Add("A95+");
                SupplyTypeComboBox.SelectedItem = selectedRow.Cells["fueltype"].Value.ToString().Trim().Replace(" ", string.Empty);
                ComboBoxDealFiller comboBoxDealFiller = new ComboBoxDealFiller(factory);
                comboBoxDealFiller.СbCardnumFill();
                CardNumberComboBox.SelectedItem = selectedRow.Cells["buyercard"].Value.ToString().Trim().Replace(" ", string.Empty);
            }
            catch (Exception) { MessageBox.Show("Невозможно выполнить операцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void UpdateDealButton_Click(object sender, EventArgs e)
        {
            try
            {
                //List<string> errorList = new List<string>();
                if (SupplyTypeComboBox.SelectedIndex != -1)
                {
                    fuelType = Convert.ToString(SupplyTypeComboBox.Text);
                }

                int fuelAmount;

                bool checkFuelAmount = Int32.TryParse(SupplyTypeAmountTextBox.Text, out fuelAmount);

                if (!checkFuelAmount)
                {
                    fuelAmount = -1;
                }

                if (CardNumberComboBox.SelectedIndex != -1)
                {
                    cardNum = Convert.ToString(CardNumberComboBox.Text).Trim().Replace(" ", string.Empty);
                }

                int dealPrice;

                bool checkDealPrice = Int32.TryParse(DealPriceTextBox.Text, out dealPrice);

                if (!checkDealPrice)
                {
                    dealPrice = -1;
                }


                if (HourTextBox.Text != String.Empty && MinuteTextBox.Text != String.Empty)
                {
                    hours = Convert.ToInt32(HourTextBox.Text);
                    minutes = Convert.ToInt32(MinuteTextBox.Text);
                    dealDate = Convert.ToDateTime(DealDatePicker.Text);
                    dealDate = dealDate.AddHours(hours);
                    dealDate = dealDate.AddMinutes(minutes);
                }
                else
                {
                    dealDate = Convert.ToDateTime(selectedRow.Cells["dealdate"].Value);
                }

                //Deal deal = new Deal();
                //deal.dealSet(factory.GetClientRepository().FindCarIDByCardnum(cardNum), fuelType, fuelAmount, dealPrice, dealDate);
                var cell = dgv[0, dgv.CurrentRow.Index];
                int id = Convert.ToInt32(cell.Value);
                DealController dealController = new DealController(dgv, factory);
                //if (dealController.UpdateTable(id, deal))
                //{
                //    MessageBox.Show("Операция выполнена успешно!");
                //    Close();
                //}
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void SupplyTypeAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDigitsAndDot(e);
        }

        private void DealPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDigitsAndDot(e);
        }

        private void HourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDigits(e);
        }

        private void MinuteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDigits(e);
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleDigitsAndDot(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void HandleDigits(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
