using System;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Controllers;
using Queries.Factory;
using Queries.Support.MessageBox;

namespace Admin
{
    public partial class AddNewClientForm : Form
    {
        private readonly Lazy<ClientController> clientController;

        public AddNewClientForm(IRepositoryFactory factory, DataGridView clientTable)
        {
            InitializeComponent();
            clientController = new Lazy<ClientController>(() => new ClientController(clientTable, factory));
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientController.Value.AddToTable(new Client(ClientNameTextBox.Text == string.Empty ? null : ClientNameTextBox.Text, 
                    ClientLastNameTextBox.Text == string.Empty ? null : ClientLastNameTextBox.Text,
                    ClientMiddleNameTextBox.Text == string.Empty ? null : ClientMiddleNameTextBox.Text,
                    int.Parse(ClientCardComboBox.SelectedItem == null ? "0" : ClientCardComboBox.SelectedItem.ToString()))))
                {
                    SuccessMessageBox.ShowSuccessBox();
                    Close();
                }
            }
            catch (Exception) { ErrorMessageBox.ShowUnknownErrorMessage(); }
        }

        private void AddNewClientForm_Load(object sender, EventArgs e)
        {
            clientController.Value.FillCardsComboBox(ClientCardComboBox);
        }

        private void ClientNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleLettersAndSpace(e);
        }

        private void ClientLastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleLettersAndSpace(e);
        }

        private void ClientMiddleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleLettersAndSpace(e);
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleLettersAndSpace(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 32 && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
