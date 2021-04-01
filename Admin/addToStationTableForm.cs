using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Repositories;
using Queries.Validators;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToStationTableForm : Form
    {
        private IRepositoryFactory factory;
        private DataGridView dgv;
        private string orgname, country, city, street;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                orgname = tbOrgName.Text.ToString();
                country = tbCountry.Text.ToString();
                city = tbCity.Text.ToString();
                street = tbStreet.Text.ToString();
                    street = CheckRigthStreet(street);
                    int storagecap;
                    bool checkStorageCap = Int32.TryParse(tbStorageCap.Text, out storagecap);
                    if (!checkStorageCap)
                    {
                        storagecap = -1;
                    }
                    Station st = new Station();
                    st.stationSet(orgname, country, city, street, storagecap);
                    StationController stationController = new StationController(dgv, factory);
                    if (stationController.AddToTable(st))
                    {
                        MessageBox.Show("Операция выполнена успешно!");
                        Close();
                    }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbOrgName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 )
                e.Handled = true;
        }

        private void tbStorageCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        public AddToStationTableForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CheckRigthStreet(string street)
        {
            for (int i = 1; i < street.Length; i++)
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
