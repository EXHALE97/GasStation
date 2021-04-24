using System;
using System.Globalization;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Controllers;
using Queries.Factory;
using Queries.Interfaces;
using Queries.Support.ComboBox;
using Queries.Support.MessageBox;

namespace Worker
{
    public partial class AddToDealTableForm : Form
    {
        private int employeeId;
        private int clientDiscountPercent;
        private DataGridView dealTable;
        private readonly IRepositoryFactory factory;
        private readonly ComboBoxFiller comboBoxFiller;
        private readonly Lazy<DealController> dealController;

        public AddToDealTableForm(int employeeId, IRepositoryFactory factory, DataGridView dealTable)
        {
            InitializeComponent();
            this.factory = factory;
            this.dealTable = dealTable;
            this.employeeId = employeeId;
            comboBoxFiller = new ComboBoxFiller(factory);
            dealController = new Lazy<DealController>(() => new DealController(dealTable, factory));
        }

        private void UpdateDealTableForm_Load(object sender, EventArgs e)
        {
            comboBoxFiller.FillCardNumbers(ClientCardComboBox);
            comboBoxFiller.FillStationNamesComboBox(StationComboBox);
            comboBoxFiller.FillSupplyTypes(SupplyTypeComboBox);
        }

        private void NowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NowCheckBox.Checked)
            {
                HoursTextBox.Visible = false;
                MinutesTextBox.Visible = false;
                HoursLabel.Visible = false;
                MinutesLabel.Visible = false;
            }
            else
            {
                HoursTextBox.Visible = true;
                MinutesTextBox.Visible = true;
                HoursLabel.Visible = true;
                MinutesLabel.Visible = true;
            }
        }

        private void AddDealButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dealDate;
                if (NowCheckBox.Checked)
                {
                    dealDate = DateTime.Now;
                }
                else
                {
                    dealDate = DealDatePicker.Value.Date;
                    if (HoursTextBox.Text != string.Empty)
                    {
                        dealDate = dealDate.AddHours(Convert.ToInt32(HoursTextBox.Text));
                    }
                    if (MinutesTextBox.Text != string.Empty)
                    {
                        dealDate = dealDate.AddMinutes(Convert.ToInt32(MinutesTextBox.Text));
                    }
                }

                if (new DealController(factory).AddToTable(new Deal(
                    factory.GetClientRepository().GetClientIdByCardId(ClientCardComboBox.SelectedIndex != -1
                        ? int.Parse(ClientCardComboBox.SelectedItem.ToString())
                        : 0),
                    StationComboBox.SelectedIndex != -1 ? StationComboBox.SelectedItem.ToString() : null, 
                    employeeId,
                    SupplyTypeComboBox.SelectedIndex != -1 ? SupplyTypeComboBox.SelectedItem.ToString() : null,
                    double.TryParse(SupplyTypeAmountTextBox.Text, out var amount) ? amount : 0,
                    double.TryParse(DealPriceTextBox.Text, out var price) ? price : 0, dealDate)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowInvalidDataMessage(); }
        }

        private void ClientCardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientCardComboBox.SelectedIndex != -1)
            {
                clientDiscountPercent = factory.GetClientRepository()
                    .GetDiscountPercentForClient(int.Parse(ClientCardComboBox.SelectedItem.ToString()));
            }
            else
            {
                clientDiscountPercent = 0;
            }
        }

        private void SupplyTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void SupplyTypeAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            CountPrice();
        }

        private void SupplyTypeAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDigitsAndDot(e);
        }

        private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyDigits(e);
        }

        private void MinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyDigits(e);
        }

        private void DealPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DealPriceTextBox.Text == string.Empty) return;
            PriceWithDiscountTextBox.Text = (double.Parse(DealPriceTextBox.Text) * ((double)(100 - clientDiscountPercent) / 100)).ToString(CultureInfo.InvariantCulture);
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private static void HandleDigitsAndDot(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }

        private static void HandleOnlyDigits(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
