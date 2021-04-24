using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;

namespace User
{
    public partial class UserForm : Form //форма пользователя
    {
        private readonly int clientId;
        private readonly IRepositoryFactory factory;
        private readonly StationController stationController;
        private readonly DealController dealController;
        

        public UserForm(int clientId, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.factory = factory;
            stationController = new StationController(StationsTable, factory);
            dealController = new DealController(DealTable, factory);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var userFullName = factory.GetClientRepository().GetClientFullNameById(clientId);
            MessageBox.Show("Добро пожаловать!");
            lbSessionName1.Text = "Вы зашли как:" + userFullName;
            lbSessionName2.Text = "Вы зашли как:" + userFullName;
            
            stationController.ShowTable(false);
            dealController.ShowUserTable(clientId);
        }

        private void dataView1_Click(object sender, EventArgs e)
        {
            stationController.ShowTable(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fCountry = tbCountry.Text;
            string fCity = tbCity.Text;
            stationController.FindInTable(fCountry, fCity);
        }

        private void btnShowUserDeal_Click(object sender, EventArgs e)
        {
            //dealController.ShowUserTable(clientId);
        }

        private void lbSessionName1_Click(object sender, EventArgs e)
        {

        }
    }
}
