using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly DataGridView dataGridView;
        private List<string> errorList;
        private string error;

        public EmployeeController(DataGridView dataGridView, IRepositoryFactory factory)
        {
            Factory = factory;
            this.dataGridView = dataGridView;
        }

        public void ShowTable(bool workingOnly)
        {
            DoFormAction(() =>
            {
                dataGridView.Rows.Clear();
                foreach(var employee in Factory.GetStaffRepository().GetEmployees(workingOnly))
                {
                    dataGridView.Rows.Add(employee.Id, employee.CredId, employee.SurName, employee.Name,
                        employee.MiddleName, employee.Birthday, employee.EmploymentDate, employee.ContractEndDate,
                        employee.Position, employee.Salary, employee.Address, employee.Phone, employee.IsWorking);
                }
            });
        }

        public bool AddToTable(Employee wk)
        {
            bool checkFlag = false;
            try
            {
                if (EmployeeValidator.CheckAddition(wk, out errorList))
                {
                    Factory.GetStaffRepository().AddToEmployeeTable(wk);
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
                if (EmployeeValidator.CheckUpdate(id, wk, out errorList))
                {
                    Factory.GetStaffRepository().UpdateEmployeeTable(id, wk);
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
                if (!EmployeeValidator.CheckDelete(id, out errorList))
                {
                    Factory.GetStaffRepository().DeleteFromEmployeeTable(id);
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
