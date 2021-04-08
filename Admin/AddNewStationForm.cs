using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
using Queries.Support.Validators;

namespace Admin
{
    public partial class AddNewStationForm : Form
    {
        private readonly Lazy<StationController> stationController;

        public AddNewStationForm(IRepositoryFactory factory, DataGridView stationsTable)
        {
            InitializeComponent();
            stationController = new Lazy<StationController>(() => new StationController(stationsTable, factory));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (stationController.Value.AddToTable(new Station(TbStationName.Text, TextBoxCity.Text,
                    StationValidator.CheckRightStreet(TextBoxAddress.Text), WorkingRadio.Checked)))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception)
            {
                ErrorMessageBox.ShowInvalidDataMessage();
            }
        }

        private void tbOrgName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 35 && e.KeyChar != 185)
                e.Handled = true;
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
