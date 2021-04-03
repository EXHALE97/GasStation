using System;
using System.Windows.Forms;
using Queries.Controllers;
using Queries.Entities;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToStationTableForm : Form
    {
        private readonly IRepositoryFactory factory;
        private readonly DataGridView stationsTable;
        private readonly Lazy<StationController> stationController;

        public AddToStationTableForm(IRepositoryFactory factory, DataGridView stationsTable)
        {
            InitializeComponent();
            this.factory = factory;
            this.stationsTable = stationsTable;
            stationController = new Lazy<StationController>(() => new StationController(stationsTable, factory));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var st = new Station(tbOrgName.Text, tbCountry.Text, tbCity.Text, CheckRightStreet(tbStreet.Text));
                if (stationController.Value.AddToTable(st))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbOrgName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 )
                e.Handled = true;
        }

        private void tbStorageCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CheckRightStreet(string street)
        {
            for (var i = 1; i < street.Length; i++)
            {
                if ((street[i] >= '0' && street[i] <= '9') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= 'А' && street[i] <= 'Я') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= 'A' && street[i] <= 'Z') && (street[i - 1] >= 'a' && street[i - 1] <= 'z'))
                {
                    street = street.Insert(i, " ");
                }
            }
            return street;
        }
    }
}
