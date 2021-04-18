using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class UpdateStationForm : Form
    {
        private readonly DataGridViewRow updatingRow;
        private readonly Lazy<StationController> stationController;

        public UpdateStationForm(DataGridViewRow updatingRow, IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            stationController = new Lazy<StationController>(() => new StationController(dgv, factory));
            this.updatingRow = updatingRow;
        }

        private void UpdateStationForm_Load(object sender, EventArgs e)
        {
            StationNameTextBox.Text = updatingRow.Cells["StationName"].Value.ToString();
            StationCityTextBox.Text = updatingRow.Cells["StationCity"].Value.ToString();
            StationAddressTextBox.Text = updatingRow.Cells["StationAddress"].Value.ToString();
            WorkingRadio.Checked = bool.Parse(updatingRow.Cells["IsStationWorking"].Value.ToString());
            NotWorkingRadio.Checked = !bool.Parse(updatingRow.Cells["IsStationWorking"].Value.ToString());
        }

        private void UpdateStationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (stationController.Value.UpdateStation(new Station(int.Parse(updatingRow.Cells["StationId"].Value.ToString()), 
                    StationNameTextBox.Text == string.Empty ? null : StationNameTextBox.Text, 
                    StationCityTextBox.Text == string.Empty ? null : StationCityTextBox.Text,
                    StationAddressTextBox.Text == string.Empty ? null : StationAddressTextBox.Text,
                    WorkingRadio.Checked)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void StationNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 35 && e.KeyChar != 185)
                e.Handled = true;
        }

        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void CancelActionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
