using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.dgvControllers;
using Queries.Interfaces;

namespace User
{
    public partial class UserForm : Form //форма пользователя
    {
        private IRepositoryFactory factory;
        private StationController fillStationTable;
        private DealController fillDealTable;
        private string cardnum;

        public UserForm(string cardnum, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.cardnum = cardnum;
            this.factory = factory; 
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать!");
            lbSessionName1.Text = "Вы зашли как:" + cardnum;
            lbSessionName2.Text = "Вы зашли как:" + cardnum;
            fillStationTable = new StationController(dgvVievAZS, factory);
            fillStationTable.ShowTable();
            fillDealTable = new DealController(dgvUserDeals, factory);
            fillDealTable.ShowUserTable(cardnum);
        }

        private void dataView1_Click(object sender, EventArgs e)
        {
            fillStationTable.ShowTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fCountry = tbCountry.Text;
            string fCity = tbCity.Text;
            fillStationTable.FindInTable(fCountry, fCity);
        }

        private void btnShowUserDeal_Click(object sender, EventArgs e)
        {
            fillDealTable.ShowUserTable(cardnum);
        }

        private void lbSessionName1_Click(object sender, EventArgs e)
        {

        }
    }
}
