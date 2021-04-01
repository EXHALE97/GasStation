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
using Queries.Repositories;
using Queries.Interfaces;
using Queries.Validators;

namespace Queries.dgvControllers
{
    public class SupplyController
    {
        private DataGridView dgv;
        private List<Supply> dgvElements;
        private IRepositoryFactory factory;
        private SupplyValidator supplyValidator;
        private List<string> errorList;
        private string error;

        public SupplyController(DataGridView dgv, IRepositoryFactory factory)
        {
            dgvElements = new List<Supply>();
            this.dgv = dgv;
            this.factory = factory;
            supplyValidator = new SupplyValidator();
        }

        public void ShowTable()
        {
            try
            {
                dgvElements = factory.GetSupplyRepository().ShowSupplyTable();
                dgv.Rows.Clear();
                foreach (Supply supply in dgvElements)
                {
                    int station_id = supply.GetStationID();
                    dgv.Rows.Add(supply.GetStationID(), RemoveSpaces(factory.GetStationRepository().GetStationAdresByID(station_id)), factory.GetStaffRepository().FindStaffByID(supply.GetStaffID()), supply.GetFuelSupplyType(),
                        supply.GetFuelSupplyAmount(), supply.GetSupplyDate());
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Ошибка базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void ShowTable(int ID)
        {
            try
            {
                int id = factory.GetStaffRepository().FindStationIDByStaffID(ID);
                dgvElements = factory.GetSupplyRepository().ShowSupplyTableByID(id);
                dgv.Rows.Clear();
                foreach (Supply supply in dgvElements)
                {
                    int station_id = supply.GetStationID();
                    dgv.Rows.Add(factory.GetStaffRepository().FindStaffByID(supply.GetStaffID()), supply.GetFuelSupplyType(), supply.GetFuelSupplyAmount(), supply.GetSupplyDate());
                }
            }
            catch (PostgresException pe)
            {
                MessageBox.Show("Код ошибки: " + pe.SqlState, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Ошибка базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public bool AddToSupplyTable(Supply sup)
        {
            bool checkFlag = false;
            try
            {
                if (checkFlag = supplyValidator.CheckAddition(sup, out errorList))
                {
                    factory.GetSupplyRepository().AddToSupplyTable(sup);
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
                MessageBox.Show(pe.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Невозможно выполнить операцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }

        public void FilterBYStationID(int id)
        {
            try
            {
                dgvElements = factory.GetSupplyRepository().GetSupplyBYStationID(id);
                dgv.Rows.Clear();
                foreach (Supply supply in dgvElements)
                {
                    dgv.Rows.Add(supply.GetStationID(), RemoveSpaces(factory.GetStationRepository().GetStationAdresByID(supply.GetStationID())), factory.GetStaffRepository().FindStaffByID(supply.GetStaffID()), supply.GetFuelSupplyType(),
                        supply.GetFuelSupplyAmount(), supply.GetSupplyDate());
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

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
