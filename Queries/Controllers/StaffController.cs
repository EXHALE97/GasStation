using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Npgsql;
using Queries.Entities;
using Queries.Repositories;
using Queries.dgvControllers;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.dgvControllers
{
    public class StaffController
    {
        private DataGridView dgv;
        private List<Worker> dgvElements;
        private IRepositoryFactory factory;
        private StaffValidator staffValidator;
        private List<string> errorList;
        private string error;

        public StaffController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Worker>();
            this.dgv = dgv;
            this.factory = factory;
            staffValidator = new StaffValidator();
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = factory.GetStaffRepository().GetStaff();
                dgv.Rows.Clear();
                if (dgvElements.Count != 0)
                {
                    foreach (Worker wk in dgvElements)
                    {
                        dgv.Rows.Add(wk.GetStaffID(), wk.GetSurname(), wk.GetName(),
                            factory.GetStationRepository().GetStationAdresByID(factory.GetStaffRepository().FindStationIDByStaffID(wk.GetStaffID())).Trim().Replace(" ", string.Empty),
                            wk.GetGender(), wk.GetBirthdate(), wk.GetFunction(), wk.GetSalary());
                    }
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool AddToTable(Worker wk)
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
            catch (PostgresException pe)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }

        public bool UpdateTable(int id, Worker wk)
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
            catch (PostgresException pe)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (PostgresException pe)
            {
                checkFlag = false;
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
