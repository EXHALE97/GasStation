using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Interfaces;

namespace Worker
{
    public partial class WorkerForm : Form
    {
        int ID;
        IRepositoryFactory factory;
        DealController fillDealTable;
        SupplyController fillSupplyTable;

        public WorkerForm(int ID, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.ID = ID;
            this.factory = factory;
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать, " + factory.GetStaffRepository().FindStaffByID(ID) + "!" + "\n" + "Желаем вам приятного рабочего дня!" + "\n");
            lbSessionName.Text = "Сессия: " + factory.GetStaffRepository().FindStaffByID(ID) + "[" + ID + "]";
            fillDealTable = new DealController(dgvVievDeal, factory);
            fillDealTable.ShowWorkerTable(ID);
            fillSupplyTable = new SupplyController(dgvViewSupply, factory);
            fillSupplyTable.ShowTable(ID);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToDealTableForm addForm = new AddToDealTableForm(ID, factory, dgvVievDeal);
            addForm.ShowDialog();
            fillDealTable.ShowWorkerTable(ID);
            fillSupplyTable.ShowTable(ID);
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            AddToSupplyTableForm addForm = new AddToSupplyTableForm(ID, factory, dgvViewSupply);
            addForm.ShowDialog();
            fillDealTable.ShowWorkerTable(ID);
            fillSupplyTable.ShowTable(ID);
        }

        private void RefreshTables_Click_1(object sender, EventArgs e)
        {
            fillDealTable.ShowWorkerTable(ID);
            fillSupplyTable.ShowTable(ID);
        }

        private void btnSupplyUpdate_Click(object sender, EventArgs e)
        {
            fillSupplyTable.ShowTable(ID);
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {

        }
    }
}
