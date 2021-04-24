using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.ComboBox;
using Queries.Support.MessageBox;

namespace Worker
{
    public partial class AddToSupplyTableForm : Form
    {
        private readonly int employeeId;
        private readonly IRepositoryFactory factory;
        private readonly Lazy<SupplyController> supplyController;
        private readonly ComboBoxFiller comboBoxFiller;

        public AddToSupplyTableForm(int employeeId, IRepositoryFactory factory, DataGridView supplyTable)
        {
            InitializeComponent();
            this.factory = factory;
            this.employeeId = employeeId;
            comboBoxFiller = new ComboBoxFiller(factory);
            supplyController = new Lazy<SupplyController>(() => new SupplyController(supplyTable, factory));
        }

        private void AddToSupplyTableForm_Load(object sender, EventArgs e)
        {
            comboBoxFiller.FillSupplyTypes(SupplyTypeComboBox);
            comboBoxFiller.FillStationNamesComboBox(StationComboBox);
        }

        private void NowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NowCheckBox.Checked)
            {
                HoursTextBox.Visible = false;
                MinutesTextBox.Visible = false;
                HoursLabel.Visible = false;
                MinutesLabel.Visible = false;
                SupplyDatePicker.Enabled = false;
            }
            else
            {
                HoursTextBox.Visible = true;
                MinutesTextBox.Visible = true;
                HoursLabel.Visible = true;
                MinutesLabel.Visible = true;
                SupplyDatePicker.Enabled = true;
            }
        }

        private void AddDealButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime supplyDate;
                if (NowCheckBox.Checked)
                {
                    supplyDate = DateTime.Now;
                }
                else
                {
                    supplyDate = SupplyDatePicker.Value.Date;
                    supplyDate = supplyDate.AddHours(int.Parse(HoursTextBox.Text));
                    supplyDate = supplyDate.AddMinutes(int.Parse(MinutesTextBox.Text));
                }
                
                if (supplyController.Value.AddToSupplyTable(
                    new Supply(factory.GetStationRepository().GetStationIdByName(StationComboBox.SelectedIndex != -1 ? StationComboBox.SelectedItem.ToString() : null),
                    employeeId,
                    factory.GetSupplyTypeRepository().GetSupplyTypeIdByName(SupplyTypeComboBox.SelectedIndex != -1 ? SupplyTypeComboBox.SelectedItem.ToString() : null),
                    SupplyAmountTextBox.Text != string.Empty ? int.Parse(SupplyAmountTextBox.Text) : 0,
                    supplyDate)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowInvalidDataMessage(); }
        }

        private void SupplyAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyDigits(e);
        }

        private void HoursTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyDigits(e);
        }

        private void MinutesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleOnlyDigits(e);
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static void HandleOnlyDigits(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
