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
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Validators;
using Queries.Interfaces;

namespace Admin
{
    public partial class AddToCarTableForm : Form
    {
        private DataGridView dgv;
        private IRepositoryFactory factory;

        public AddToCarTableForm(IRepositoryFactory factory, DataGridView dgv)
        {
            InitializeComponent();
            this.factory = factory;
            this.dgv = dgv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string carMark, cardNum;
                carMark = tbCarMark.Text.ToString();
                cardNum = tbCardNum.Text.ToString();
                Car car = new Car();
                car.buyerSet(carMark, cardNum);
                CarController carController = new CarController(dgv, factory);
                if (carController.AddToTable(car))
                {
                    MessageBox.Show("Операция выполнена успешно!");
                    Close();
                }
            }
            catch (Exception) { MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
