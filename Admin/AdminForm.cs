using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.Backup;
using Queries.Support.ComboBox;
using Queries.Support.Export;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AdminForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly EmployeeController employeeController;
        private readonly ClientController clientController;
        private readonly WarehouseController warehouseController;
        private readonly DealController dealController;
        private readonly StationController stationController;
        private readonly SupplyController supplyController;
        private readonly SupplyTypeController supplyTypeController;
        private readonly ComboBoxFiller comboBoxFiller;
        private readonly Lazy<BackupTool> backupTool;

        public AdminForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            stationController = new StationController(StationsTable, factory);
            employeeController = new EmployeeController(EmployeeTable, factory);
            clientController = new ClientController(ClientTable, factory);
            warehouseController = new WarehouseController(WarehouseTable, factory);
            dealController = new DealController(DealTable, factory);
            supplyController = new SupplyController(SuppliesTable, factory);
            supplyTypeController = new SupplyTypeController(SupplyTypeTable, factory);
            comboBoxFiller = new ComboBoxFiller(factory);
            backupTool = new Lazy<BackupTool>(() => new BackupTool(factory));
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, администратор!");
            
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
            employeeController.ShowTable(OnlyWorkingEmployeeCheckBox.Checked);
            clientController.ShowTable();
            dealController.ShowTable();
            supplyController.ShowTable();
            supplyTypeController.ShowTable();
            warehouseController.ShowTable();
            comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            comboBoxFiller.FillStationNamesComboBox(SupplyFilterByStation);
            comboBoxFiller.FillStationNamesComboBox(WhFilterByStation);
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
            new UpdateDealForm(DealTable.CurrentRow, factory).ShowDialog();
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
            dealController.ShowTable();
            supplyController.ShowTable();
            supplyTypeController.ShowTable();
            warehouseController.ShowTable();
            comboBoxFiller.FillStationNamesComboBox(DealFilterByStation);
            comboBoxFiller.FillStationNamesComboBox(SupplyFilterByStation);
            comboBoxFiller.FillStationNamesComboBox(WhFilterByStation);
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

        private void WhFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhFilterByStation.SelectedIndex != -1)
            {
                warehouseController.FilterTableByStationId(WhFilterByStation.SelectedItem.ToString());
                WhFilterByStation.Items.Clear();
                comboBoxFiller.FillStationNamesComboBox(WhFilterByStation);
            }
        }

        private void SupplyFilterByStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplyFilterByStation.SelectedIndex != -1)
            {
                supplyController.FilterByStationId(SupplyFilterByStation.SelectedItem.ToString());
                SupplyFilterByStation.Items.Clear();
                comboBoxFiller.FillStationNamesComboBox(SupplyFilterByStation);
            }
        }

        private void RefreshWarehouseInfoButton_Click(object sender, EventArgs e)
        {
            warehouseController.ShowTable();
        }

        private void RefreshSupplyTableButton_Click(object sender, EventArgs e)
        {
            supplyController.ShowTable();
        }

        private void UpdateStationInfoButton_Click(object sender, EventArgs e)
        {
            new UpdateStationForm(StationsTable.CurrentRow, factory, StationsTable).ShowDialog();
            stationController.ShowTable(OnlyWorkingStationsCheckBox.Checked);
        }

        private void OnlyWorkingStationsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            stationController.ShowTable(((CheckBox)sender).Checked);
        }

        private void OnlyWorkingEmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            employeeController.ShowTable(((CheckBox)sender).Checked);
        }

        private void RefreshSupplyTypeTableButton_Click(object sender, EventArgs e)
        {
            supplyTypeController.ShowTable();
        }

        private void UpdateSupplyTypeButton_Click(object sender, EventArgs e)
        {
            new UpdateSupplyTypeForm(SupplyTypeTable.CurrentRow, factory, SupplyTypeTable).ShowDialog();
            supplyTypeController.ShowTable();
        }

        private void DeleteSupplyTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (supplyTypeController.DeleteCurrentRowFromTable(int.Parse(SupplyTypeTable.CurrentRow.Cells["SupplyTypeId"].Value.ToString())))
                {
                    SuccessMessageBox.ShowSuccessBox();
                }
                supplyTypeController.ShowTable();
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HistoryForm(factory).ShowDialog();
        }

        private void PrintDocStationsButton_Click(object sender, EventArgs e)
        {
            PrintStationTable.Print();
        }

        private void PrintStationTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(StationsTable, e);
        }

        private void ExportStationsTable_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(StationsTable);
        }

        private void PrintEmployeesButton_Click(object sender, EventArgs e)
        {
            PrintEmployeesTable.Print();
        }

        private void ExportEmployeesButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(EmployeeTable);
        }

        private void PrintClientsButton_Click(object sender, EventArgs e)
        {
            PrintClientsTable.Print();
        }

        private void ExportClientsButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(ClientTable);
        }

        private void PrintDealsButton_Click(object sender, EventArgs e)
        {
            PrintDealsTable.Print();
        }

        private void ExportDealsButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(StationsTable);
        }

        private void PrintSuppliesButton_Click(object sender, EventArgs e)
        {
            PrintSuppliesTable.Print();
        }

        private void ExportSuppliesButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(SuppliesTable);
        }

        private void PrintWarehouseButton_Click(object sender, EventArgs e)
        {
            PrintWarehouseTable.Print();
        }

        private void ExportWarehouseButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(WarehouseTable);
        }

        private void PrintProductsButton_Click(object sender, EventArgs e)
        {
            PrintProductsTable.Print();
        }

        private void ExportProductsButton_Click(object sender, EventArgs e)
        {
            DataExport.ExportInCsv(SupplyTypeTable);
        }

        private void PrintClientsTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(ClientTable, e);
        }

        private void PrintEmployeesTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(EmployeeTable, e);
        }

        private void PrintDealsTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(DealTable, e);
        }

        private void PrintSuppliesTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(SuppliesTable, e);
        }

        private void PrintWarehouseTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(WarehouseTable, e);
        }

        private void PrintProductsTable_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataExport.PrintTable(SupplyTypeTable, e);
        }

        private void CreateBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupTool.Value.CreateBackup();
        }

        private void RestoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupTool.Value.RestoreBackup();
        }
    }
}
