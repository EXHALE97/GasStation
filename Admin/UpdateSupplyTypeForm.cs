using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class UpdateSupplyTypeForm : Form
    {
        private readonly DataGridViewRow updatingRow;
        private readonly Lazy<SupplyTypeController> supplyTypeController;
        
        public UpdateSupplyTypeForm(DataGridViewRow updatingRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            supplyTypeController = new Lazy<SupplyTypeController>(() => new SupplyTypeController(dgv, factory));
            this.updatingRow = updatingRow;
        }

        private void UpdateStationForm_Load(object sender, EventArgs e)
        {
            SupplyTypeNameTextBox.Text = updatingRow.Cells["SupplyTypeName"].Value.ToString();
            SupplyTypePriceTextBox.Text = updatingRow.Cells["SupplyTypePrice"].Value.ToString();
            SellingRadio.Checked = bool.Parse(updatingRow.Cells["IsSupplyTypeSelling"].Value.ToString());
            NotSellingRadio.Checked = !bool.Parse(updatingRow.Cells["IsSupplyTypeSelling"].Value.ToString());
        }

        private void UpdateSupplyTpeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplyTypeController.Value.UpdateSupplyType(new SupplyType(int.Parse(updatingRow.Cells["SupplyTypeId"].Value.ToString()),
                    SupplyTypeNameTextBox.Text == string.Empty ? null : SupplyTypeNameTextBox.Text,
                    SupplyTypePriceTextBox.Text == string.Empty ? 0 : double.Parse(SupplyTypePriceTextBox.Text),
                    SellingRadio.Checked)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void SupplyTypeNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void SupplyTypePriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
                e.Handled = true;
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
