using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using Queries;
using Queries.dgvControllers;
using Queries.Repositories;
using Queries.Validators;
using Queries.Interfaces;
using Queries.comboBoxFillers;

namespace Admin
{
    public partial class AdminForm : Form
    {
        private IRepositoryFactory factory;
        private StaffController fillStaffTable;
        private CarController fillCarTable;
        private AccountController fillAccountingTable;
        private DealController fillDealTable;
        private StationController fillStationTable;
        private SupplyController fillSupplyTable;
        private ComboBoxDealFiller fillComboBoxDeal;
        private ComboBoxAccountingFiller fillComboBoxAccounting;
        private ComboBoxSupplyFiller fillComboBoxSupply;

        public AdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;                       
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, администратор!");
            fillStationTable = new StationController(dgvVievAZS, factory);
            fillStationTable.ShowAdminTable();           
            fillStaffTable = new StaffController(dgvViewStaff, factory);
            fillStaffTable.ShowTable();
            fillCarTable = new CarController(dgvViewCars, factory);
            fillCarTable.ShowTable();
            fillAccountingTable = new AccountController(dgvViewAccounting, factory);
            fillAccountingTable.ShowTable();
            fillDealTable = new DealController(dgvViewDeal, factory);
            fillDealTable.ShowTable();
            fillSupplyTable = new SupplyController(dgvViewSupply, factory);
            fillSupplyTable.ShowTable();
            fillComboBoxDeal = new ComboBoxDealFiller(cbDealFilterByStation, factory);
            fillComboBoxDeal.СbStationListFill();
            fillComboBoxAccounting = new ComboBoxAccountingFiller(cbAccountingFilterByStation, factory);
            fillComboBoxAccounting.СbStationListFill();
            fillComboBoxSupply = new ComboBoxSupplyFiller(cbSupplyFilterByStation, factory);
            fillComboBoxSupply.СbStationListFill();
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {
            fillStaffTable = new StaffController(dgvViewStaff, factory);
            fillStaffTable.ShowTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStaffTableForm updateForm = new UpdateStaffTableForm(dgvViewStaff.CurrentRow, factory, dgvViewStaff);
            updateForm.ShowDialog();
            fillStaffTable.ShowTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToStaffTableForm addForm = new AddToStaffTableForm(factory, dgvViewStaff);
            addForm.ShowDialog();
            fillStaffTable.ShowTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var cell = dgvViewStaff[0, dgvViewStaff.CurrentRow.Index];
                int id = Convert.ToInt32(cell.Value);
                StaffController staffController = new StaffController(dgvViewStaff, factory);
                if (staffController.DeleteFromTable(id))
                {
                    factory.GetLoginRepository().DeleteStaffFromLoginTable(id.ToString());
                    MessageBox.Show("Операция выполнена успешно!");
                }
                fillStaffTable.ShowTable();
            }
            catch (Exception) { MessageBox.Show("Операция не может быть выполнена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnFindDeals_Click(object sender, EventArgs e)
        {
            var cell = dgvViewCars[0, dgvViewCars.CurrentRow.Index];
            int id = Convert.ToInt32(cell.Value);
            DealList dealList = new DealList(id, factory);
            dealList.ShowDialog();
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            AddToCarTableForm addForm = new AddToCarTableForm(factory, dgvViewCars);
            addForm.ShowDialog();
            fillCarTable.ShowTable();
        }

        private void btnDealUpdate_Click(object sender, EventArgs e)
        {
            UpdateDealTableForm updateDealForm = new UpdateDealTableForm(dgvViewDeal.CurrentRow, factory, dgvViewDeal);
            updateDealForm.ShowDialog();
        }

        private void btnStationAdd_Click(object sender, EventArgs e)
        {
            AddToStationTableForm addForm = new AddToStationTableForm(factory, dgvViewCars);
            addForm.ShowDialog();
            fillStationTable.ShowAdminTable();
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
            fillStationTable.ShowAdminTable();
            fillStaffTable.ShowTable();
            fillCarTable.ShowTable();
            fillAccountingTable.ShowTable();
            fillDealTable.ShowTable();
            cbDealFilterByStation.Items.Clear();
            fillComboBoxDeal.СbStationListFill();
            cbAccountingFilterByStation.Items.Clear();
            fillComboBoxAccounting.СbStationListFill();
            cbSupplyFilterByStation.Items.Clear();
            fillComboBoxSupply.СbStationListFill();
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            AddNewAdminForm addAdminForm = new AddNewAdminForm(factory);
            addAdminForm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AddWorkerToLoginTableForm addLoginForm = new AddWorkerToLoginTableForm(dgvViewStaff.CurrentRow, factory);
            addLoginForm.ShowDialog();
        }

        private void btnActivateCarCard_Click(object sender, EventArgs e)
        {
            AddUserToLoginTableForm addLoginForm = new AddUserToLoginTableForm(dgvViewCars.CurrentRow, factory);
            addLoginForm.ShowDialog();
        }

        private void btnTableStationView_Click(object sender, EventArgs e)
        {
            fillStationTable.ShowAdminTable();
        }

        private void btnTableCarView_Click(object sender, EventArgs e)
        {
            fillCarTable.ShowTable();
        }

        private void btnTableDealView_Click(object sender, EventArgs e)
        {
            fillDealTable.ShowTable();
        }

        private void cbFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDealFilterByStation.SelectedIndex != -1)
            {
                fillDealTable.FindDealsByStationID(factory.GetStationRepository().FindStationIDByLocation(cbDealFilterByStation.Text));
                cbDealFilterByStation.Items.Clear();
                fillComboBoxDeal.СbStationListFill();
            }
        }

        private void cbAccountingFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountingFilterByStation.SelectedIndex != -1)
            {
                fillAccountingTable.FilterBYStationID(factory.GetStationRepository().FindStationIDByLocation(cbAccountingFilterByStation.Text));
                cbAccountingFilterByStation.Items.Clear();
                fillComboBoxAccounting.СbStationListFill();
            }
        }

        private void cbSupplyFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSupplyFilterByStation.SelectedIndex != -1)
            {
                fillSupplyTable.FilterBYStationID(factory.GetStationRepository().FindStationIDByLocation(cbSupplyFilterByStation.Text));
                cbSupplyFilterByStation.Items.Clear();
                fillComboBoxSupply.СbStationListFill();
            }
        }

        private void btnTableAccountingView_Click(object sender, EventArgs e)
        {
            fillAccountingTable.ShowTable();
        }

        private void btnTableSupplyView_Click(object sender, EventArgs e)
        {
            fillSupplyTable.ShowTable();
        }


    }
}
