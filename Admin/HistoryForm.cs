using System;
using System.Windows.Forms;
using Queries.Factory;

namespace Admin
{
    public partial class HistoryForm : Form
    {
        private readonly IRepositoryFactory factory;

        public HistoryForm(IRepositoryFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
        }

        private void ShowHistoryForm_Load(object sender, EventArgs e)
        {
            foreach (var operation in factory.GetHistoryRepository().GetHistory())
            {
                HistoryTable.Rows.Add(operation.Id, operation.Operation, operation.Date);
            }
        }
    }
}
