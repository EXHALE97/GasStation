using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.ComboBox;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AdminForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly EmployeeController employeeController;
        private readonly ClientController clientController;
        private readonly AccountController accountingController;
        private readonly DealController dealController;
        private readonly StationController stationController;
        private readonly SupplyController supplyController;
        private readonly ComboBoxFiller comboBoxFiller;

        public AdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            stationController = new StationController(StationsTable, factory);
            employeeController = new EmployeeController(EmployeeTable, factory);
            clientController = new ClientController(ClientTable, factory);
            accountingController = new AccountController(dgvViewAccounting, factory);
            dealController = new DealController(DealTable, factory);
            supplyController = new SupplyController(dgvViewSupply, factory);
            comboBoxFiller = new ComboBoxFiller(factory);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, администратор!");
            
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
            clientController.ShowTable();
            dealController.ShowTable();
            comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            supplyController.ShowTable();
            comboBoxFiller.FillStationNamesComboBox(SupplyFilterBytation);
            //accountingController.ShowTable();



            //accountingComboBox.FillStationNamesComboBox();
            //supplyComboBox.FillStationNamesComboBox();
        }

        private void RefreshEmployeeTable_Click(object sender, EventArgs e)
        {
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            new UpdateEmployeeForm(EmployeeTable.CurrentRow, factory, EmployeeTable).ShowDialog();
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            new AddNewEmployeeForm(factory, EmployeeTable).ShowDialog();
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeController.DeleteCurrentRowFromTable(int.Parse(EmployeeTable.CurrentRow.Cells["EmployeeId"].Value.ToString())))
                {
                    SuccessMessageBox.ShowSuccessBox();
                }
                employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void FindDealsByClientButton_Click(object sender, EventArgs e)
        {
            new DealListForClientForm(int.Parse(ClientTable.CurrentRow.Cells["ClientId"].Value.ToString()), factory).ShowDialog();
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            new AddNewClientForm(factory, ClientTable).ShowDialog();
            clientController.ShowTable();
        }

        private void DealUpdateButton_Click(object sender, EventArgs e)
        {
            new UpdateDealTableForm(DealTable.CurrentRow, factory).ShowDialog();
            dealController.ShowTable();
        }

        private void AddNewStationButton_Click(object sender, EventArgs e)
        {
            new AddNewStationForm(factory, ClientTable).ShowDialog();
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
            clientController.ShowTable();
            accountingController.ShowTable();
            dealController.ShowTable();
            DealFilterByStation.Items.Clear();
            comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            WhFilterByStation.Items.Clear();
        }

        private void AddNewAdmin_Click(object sender, EventArgs e)
        {
            new AddNewAdminForm(factory).ShowDialog();
        }

        private void GiveAdminAccessButton_Click(object sender, EventArgs e)
        {
            new AddWorkerToLoginTableForm(EmployeeTable.CurrentRow, factory).ShowDialog();
        }

        private void ActivateClientCardButton_Click(object sender, EventArgs e)
        {
            new AddUserToLoginTableForm(ClientTable.CurrentRow, factory).ShowDialog();
        }

        private void RefreshStationTableButton_Click(object sender, EventArgs e)
        {
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
        }

        private void UpdateClientTableButton_Click(object sender, EventArgs e)
        {
            clientController.ShowTable();
        }

        private void DealTableRefreshButton_Click(object sender, EventArgs e)
        {
            dealController.ShowTable();
        }

        private void FilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DealFilterByStation.SelectedIndex != -1)
            {
                dealController.ShowDealTableByStation(DealFilterByStation.SelectedItem.ToString());
                DealFilterByStation.Items.Clear();
                comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            }
        }

        private void cbAccountingFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhFilterByStation.SelectedIndex != -1)
            {
                accountingController.FilterBYStationID(factory.GetStationRepository().GetStationIdByName(WhFilterByStation.Text));
                WhFilterByStation.Items.Clear();
                comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            }
        }

        private void cbSupplyFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplyFilterBytation.SelectedIndex != -1)
            {
                supplyController.FilterBYStationID(factory.GetStationRepository().GetStationIdByName(SupplyFilterBytation.Text));
                SupplyFilterBytation.Items.Clear();
                comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            }
        }

        private void ViewAccountingTable(object sender, EventArgs e)
        {
            accountingController.ShowTable();
        }

        private void RefreshSupplyTableButton_Click(object sender, EventArgs e)
        {
            supplyController.ShowTable();
        }

        private void UpdateStationInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void OnlyWorkingStationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            stationController.ShowTable(((CheckBox)sender).Checked);
        }

        private void OnlyWorkingEmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            employeeController.ShowTable(((CheckBox)sender).Checked);
        }
    }
}
