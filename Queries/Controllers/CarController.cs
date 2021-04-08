using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class CarController
    {
        private DataGridView dgv;
        private List<Client> dgvElements;
        private IRepositoryFactory factory;
        private CarValidator carValidator;
        private List<string> errorList;
        private string error;

        public CarController(DataGridView dgv, IRepositoryFactory factory)
        {
            this.factory = factory;
            this.dgv = dgv;
            carValidator = new CarValidator();
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = factory.GetCarRepository().GetCars();
                dgv.Rows.Clear();
                foreach (Client car in dgvElements)
                {
                    dgv.Rows.Add(car.GetCarID(), car.GetCarMark(), car.GetCardNum());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddToTable(Client car)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = carValidator.CheckAddition(car, out errorList))
                {
                    factory.GetCarRepository().AddToCarTable(car);
                }
                else
                {
                    int k = 0;
                    foreach (string str in errorList)
                    {
                        k++;
                        error += "Ошибка №" + k + ": " + str + " \n";
                    }
                    MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }
    }
}
