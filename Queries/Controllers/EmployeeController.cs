using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Interfaces;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class EmployeeController
    {
        private readonly IRepositoryFactory factory;
        private readonly DataGridView dataGridView;
        private readonly StaffValidator staffValidator;
        private List<Employee> dgvElements;
        private List<string> errorList;
        private string error;

        public EmployeeController(DataGridView dataGridView, IRepositoryFactory factory)
        {
            this.dataGridView = dataGridView;
            this.factory = factory;
            staffValidator = new StaffValidator();
            dgvElements = new List<Employee>();
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = factory.GetStaffRepository().GetStaff();
                dataGridView.Rows.Clear();
                if (dgvElements.Count != 0)
                {
                    foreach (Employee wk in dgvElements)
                    {
                        dataGridView.Rows.Add(wk.GetStaffID(), wk.GetSurname(), wk.GetName(),
                            factory.GetStationRepository().GetStationAddressById(factory.GetStaffRepository().FindStationIDByStaffID(wk.GetStaffID())).Trim().Replace(" ", string.Empty),
                            wk.GetGender(), wk.GetBirthdate(), wk.GetFunction(), wk.GetSalary());
                    }
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

        public bool AddToTable(Employee wk)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = staffValidator.CheckAddition(wk, out errorList))
                {
                    factory.GetStaffRepository().AddToStaffTable(wk);
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

        public bool UpdateTable(int id, Employee wk)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = staffValidator.CheckUpdate(id, wk, out errorList))
                {
                    factory.GetStaffRepository().UpdateStaffTable(id, wk);
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

        public bool DeleteFromTable(int id)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = staffValidator.CheckDelete(id, out errorList))
                {
                    factory.GetStaffRepository().DeleteFromStaffTable(id);
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
