using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.ComboBox;

namespace User
{
    public partial class UserForm : Form //форма пользователя
    {
        private readonly int clientId;
        private readonly IRepositoryFactory factory;
        private readonly StationController stationController;
        private readonly DealController dealController;
        

        public UserForm(int credId, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            clientId = factory.GetClientRepository().GetClientIdByCredId(credId);
            stationController = new StationController(StationsTable, factory);
            dealController = new DealController(DealTable, factory);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var userFullName = factory.GetClientRepository().GetClientFullNameById(clientId);
            MessageBox.Show("Добро пожаловать!");
            SessionNameStations.Text = "Вы зашли как:" + userFullName;
            SessionNameDeal.Text = "Вы зашли как:" + userFullName;
            stationController.ShowTable(false);
            dealController.ShowUserTable(clientId);
            new ComboBoxFiller(factory).FillStationCitiesComboBox(CityComboBox);
        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityComboBox.SelectedIndex != -1)
            {
                stationController.ShowStationsByCity(CityComboBox.SelectedItem.ToString());
            }
        }

        private void RefreshStationTable_Click(object sender, EventArgs e)
        {
            stationController.ShowTable(false);
            CityComboBox.SelectedIndex = -1;
        }

        private void RefreshDealTable_Click(object sender, EventArgs e)
        {
            dealController.ShowUserTable(clientId);
        }
    }
}
