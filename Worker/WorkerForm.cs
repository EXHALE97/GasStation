using System;
using System.Linq;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;

namespace Worker
{
    public partial class WorkerForm : Form
    {
        private readonly int employeeId;
        private readonly IRepositoryFactory factory;
        private readonly DealController dealController;
        private readonly SupplyController supplyController;

        public WorkerForm(int credId, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
            dealController = new DealController(DealsTable, factory);
            supplyController = new SupplyController(SuppliesTable, factory);
            employeeId = factory.GetEmployeeRepository().GetEmployees(false).First(employee => employee.CredId == credId).Id;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            var fullName = factory.GetEmployeeRepository().GetEmployeeFullNameById(employeeId);
            MessageBox.Show("Добро пожаловать, " + fullName + "!\n" + "Желаем вам приятного рабочего дня!\n");
            lbSessionName.Text = "Сессия: " + fullName + '[' + employeeId + ']';
            dealController.ShowWorkerTable(employeeId);
            supplyController.ShowEmployeeTable(employeeId);
        }

        private void AddDealButton_Click(object sender, EventArgs e)
        {
            new AddToDealTableForm(employeeId, factory, DealsTable).ShowDialog();
            dealController.ShowWorkerTable(employeeId);
            supplyController.ShowEmployeeTable(employeeId);
        }

        private void AddSupplyTable_Click(object sender, EventArgs e)
        {
            new AddToSupplyTableForm(employeeId, factory, SuppliesTable).ShowDialog();
            dealController.ShowWorkerTable(employeeId);
            supplyController.ShowEmployeeTable(employeeId);
        }

        private void RefreshTables_Click(object sender, EventArgs e)
        {
            dealController.ShowWorkerTable(employeeId);
            supplyController.ShowEmployeeTable(employeeId);
        }

        private void RefreshSupplyTableButton_Click(object sender, EventArgs e)
        {
            supplyController.ShowEmployeeTable(employeeId);
        }

        private void RefreshDealTableButton_Click(object sender, EventArgs e)
        {
            dealController.ShowWorkerTable(employeeId);
        }
    }
}
