using System;
using System.Windows.Forms;
using Queries.Interfaces;
using Queries.comboBoxFillers;
using Queries.Controllers;

namespace Admin
{
    public partial class AdminForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly EmployeeController employeeController;
        private readonly CarController clientController;
        private readonly AccountController accountingController;
        private readonly DealController dealController;
        private readonly StationController stationController;
        private readonly SupplyController supplyController;
        private readonly ComboBoxDealFiller dealComboBox;
        private readonly ComboBoxAccountingFiller accountingComboBox;
        private readonly ComboBoxSupplyFiller supplyComboBox;

        public AdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            stationController = new StationController(dgvVievStations, factory);
            employeeController = new EmployeeController(dgvViewStaff, factory);
            clientController = new CarController(dgvViewCars, factory);
            accountingController = new AccountController(dgvViewAccounting, factory);
            dealController = new DealController(dgvViewDeal, factory);
            supplyController = new SupplyController(dgvViewSupply, factory);
            dealComboBox = new ComboBoxDealFiller(cbDealFilterByStation, factory);
            accountingComboBox = new ComboBoxAccountingFiller(cbAccountingFilterByStation, factory);
            supplyComboBox = new ComboBoxSupplyFiller(cbSupplyFilterByStation, factory);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, администратор!");
            
            stationController.ShowTable();
            employeeController.ShowTable();
            clientController.ShowTable();
            accountingController.ShowTable();
            dealController.ShowTable();
            supplyController.ShowTable();
            dealComboBox.СbStationListFill();
            accountingComboBox.СbStationListFill();
            supplyComboBox.СbStationListFill();
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            employeeController.ShowTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new UpdateStaffTableForm(dgvViewStaff.CurrentRow, factory, dgvViewStaff).ShowDialog();
            employeeController.ShowTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddToStaffTableForm(factory, dgvViewStaff).ShowDialog();
            employeeController.ShowTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var cell = dgvViewStaff[0, dgvViewStaff.CurrentRow.Index];
                int id = Convert.ToInt32(cell.Value);
                if (employeeController.DeleteFromTable(id))
                {
                    factory.GetLoginRepository().DeleteStaffFromLoginTable(id.ToString());
                    MessageBox.Show("Операция выполнена успешно!");
                }
                employeeController.ShowTable();
            }
            catch (Exception) { MessageBox.Show("Операция не может быть выполнена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFindDeals_Click(object sender, EventArgs e)
        {
            new DealList(Convert.ToInt32(dgvViewCars[0, dgvViewCars.CurrentRow.Index].Value), factory).ShowDialog();
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            new AddToCarTableForm(factory, dgvViewCars).ShowDialog();
            clientController.ShowTable();
        }

        private void btnDealUpdate_Click(object sender, EventArgs e)
        {
            new UpdateDealTableForm(dgvViewDeal.CurrentRow, factory, dgvViewDeal).ShowDialog();
        }

        private void btnStationAdd_Click(object sender, EventArgs e)
        {
            new AddToStationTableForm(factory, dgvViewCars).ShowDialog();
            stationController.ShowTable();
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
            stationController.ShowTable();
            employeeController.ShowTable();
            clientController.ShowTable();
            accountingController.ShowTable();
            dealController.ShowTable();
            cbDealFilterByStation.Items.Clear();
            dealComboBox.СbStationListFill();
            cbAccountingFilterByStation.Items.Clear();
            accountingComboBox.СbStationListFill();
            cbSupplyFilterByStation.Items.Clear();
            supplyComboBox.СbStationListFill();
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            new AddNewAdminForm(factory).ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new AddWorkerToLoginTableForm(dgvViewStaff.CurrentRow, factory).ShowDialog();
        }

        private void btnActivateCarCard_Click(object sender, EventArgs e)
        {
            new AddUserToLoginTableForm(dgvViewCars.CurrentRow, factory).ShowDialog();
        }

        private void btnTableStationView_Click(object sender, EventArgs e)
        {
            stationController.ShowTable();
        }

        private void btnTableCarView_Click(object sender, EventArgs e)
        {
            clientController.ShowTable();
        }

        private void btnTableDealView_Click(object sender, EventArgs e)
        {
            dealController.ShowTable();
        }

        private void cbFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDealFilterByStation.SelectedIndex != -1)
            {
                dealController.FindDealsByStationID(factory.GetStationRepository().FindStationIdByLocation(cbDealFilterByStation.Text));
                cbDealFilterByStation.Items.Clear();
                dealComboBox.СbStationListFill();
            }
        }

        private void cbAccountingFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountingFilterByStation.SelectedIndex != -1)
            {
                accountingController.FilterBYStationID(factory.GetStationRepository().FindStationIdByLocation(cbAccountingFilterByStation.Text));
                cbAccountingFilterByStation.Items.Clear();
                accountingComboBox.СbStationListFill();
            }
        }

        private void cbSupplyFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSupplyFilterByStation.SelectedIndex != -1)
            {
                supplyController.FilterBYStationID(factory.GetStationRepository().FindStationIdByLocation(cbSupplyFilterByStation.Text));
                cbSupplyFilterByStation.Items.Clear();
                supplyComboBox.СbStationListFill();
            }
        }

        private void btnTableAccountingView_Click(object sender, EventArgs e)
        {
            accountingController.ShowTable();
        }

        private void btnTableSupplyView_Click(object sender, EventArgs e)
        {
            supplyController.ShowTable();
        }
    }
}
