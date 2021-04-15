using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Factory;

namespace Admin
{
    public partial class DealListForClientForm : Form
    {
        private readonly int clientId;
        private readonly IRepositoryFactory factory;

        public DealListForClientForm(int clientId, IRepositoryFactory factory)
        {
            InitializeComponent();
            this.clientId = clientId;
            this.factory = factory; 
        }

        private void DealListForm_Load(object sender, EventArgs e)
        {
            if (new DealController(dgvDealList, factory).ShowDealsForClient(clientId) == 0)
            {
                Close();
            }
        }
    }
}
