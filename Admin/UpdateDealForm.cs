using System;
using System.Globalization;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.ComboBox;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class UpdateDealForm : Form
    {
        private readonly int clientDiscountPercent;
        private readonly IRepositoryFactory factory;
        private readonly DataGridViewRow selectedRow;
        private readonly ComboBoxFiller comboBoxFiller;

        public UpdateDealForm(DataGridViewRow selectedRow, IRepositoryFactory factory)
        {
            InitializeComponent();
            comboBoxFiller = new ComboBoxFiller(factory);
            this.selectedRow = selectedRow;
            this.factory = factory;
            clientDiscountPercent = factory.GetClientRepository()
                .GetDiscountPercentForClient(int.Parse(selectedRow.Cells["ClientCardId"].Value.ToString()));
        }
        
        private void UpdateDealTableForm_Load(object sender, EventArgs e)
        {
            try
            {
                var date = Convert.ToDateTime(selectedRow.Cells["DealDate"].Value);
                DealDatePicker.Value = date;
                SupplyTypeAmountTextBox.Text = selectedRow.Cells["SupplyTypeAmount"].Value.ToString();
                DealPriceTextBox.Text = selectedRow.Cells["PriceWithoutDiscount"].Value.ToString();
                comboBoxFiller.FillCardNumbers(CardNumberComboBox);
                comboBoxFiller.FillSupplyTypes(SupplyTypeComboBox);
                SupplyTypeComboBox.SelectedItem = selectedRow.Cells["SupplyType"].Value.ToString();
                CardNumberComboBox.SelectedItem = int.Parse(selectedRow.Cells["ClientCardId"].Value.ToString());
                MinuteTextBox.Text = date.Minute.ToString();
                HourTextBox.Text = date.Hour.ToString();
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void UpdateDealButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dealDate = Convert.ToDateTime(DealDatePicker.Value);
                if (HourTextBox.Text != string.Empty && MinuteTextBox.Text != string.Empty)
                {
                    dealDate = dealDate.AddHours(Convert.ToInt32(HourTextBox.Text));
                    dealDate = dealDate.AddMinutes(Convert.ToInt32(MinuteTextBox.Text));
                }
                
                if (new DealController(factory).UpdateTable(new Deal
                    (int.Parse(selectedRow.Cells["DealId"].Value.ToString()), 
                    CardNumberComboBox.SelectedIndex != -1 ? int.Parse(CardNumberComboBox.SelectedItem.ToString()) : 0, 
                    SupplyTypeComboBox.SelectedIndex != -1 ? SupplyTypeComboBox.Text : null, 
                    double.TryParse(SupplyTypeAmountTextBox.Text, out var amount) ? amount : 0, 
                    double.TryParse(DealPriceTextBox.Text, out var price) ? price : 0, dealDate)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowInvalidDataMessage(); }
        }

        private void SupplyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void SupplyTypeAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void DealPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DealPriceTextBox.Text == string.Empty) return;
            PriceWithDiscountTextBox.Text = (double.Parse(DealPriceTextBox.Text) * ((double)(100 - clientDiscountPercent) / 100)).ToString(CultureInfo.InvariantCulture);
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

        private static void HandleDigitsAndDot(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }

        private static void HandleDigits(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CountPrice()
        {
            if (SupplyTypeAmountTextBox.Text == string.Empty) return;
            if (SupplyTypeComboBox.SelectedIndex == -1) return;
            DealPriceTextBox.Text =
                (factory.GetSupplyTypeRepository()
                     .GetSupplyTypePriceByName(SupplyTypeComboBox.SelectedItem.ToString()) *
                 double.Parse(SupplyTypeAmountTextBox.Text)).ToString(CultureInfo.InvariantCulture);
        }
    }
}
