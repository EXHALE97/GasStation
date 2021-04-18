using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.Validators;

namespace Queries.Controllers
{
    public class SupplyController : BaseController
    {
        private readonly DataGridView supplyTable;

        public SupplyController(DataGridView supplyTable, IRepositoryFactory factory)
        {
            Factory = factory;
            this.supplyTable = supplyTable;
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            {
                supplyTable.Rows.Clear();
                foreach (var supply in Factory.GetSupplyRepository().GetSupplies())
                {
                    supplyTable.Rows.Add(supply.StationId, supply.StationName, supply.EmployeeName, supply.SupplyTypeId,
                        supply.SupplyTypeName, supply.SupplyTypeAmount, supply.SupplyDate);
                }
            });
        }

        public void ShowTable(int ID)
        {
            try
            {
                //int id = factory.GetEmployeeRepository().FindStationIDByStaffID(ID);
                //dgvElements = factory.GetSupplyRepository().ShowSupplyTableByID(id);
                //supplyTable.Rows.Clear();
                //foreach (Supply supply in dgvElements)
                //{
                //    int station_id = supply.GetStationID();
                //    supplyTable.Rows.Add(factory.GetEmployeeRepository().FindEmployeeById(supply.GetStaffID()), supply.GetFuelSupplyType(), supply.GetFuelSupplyAmount(), supply.GetSupplyDate());
                //}
            }
            catch (SqlException e)
            {
                MessageBox.Show("Код ошибки: " + e.State, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) { MessageBox.Show("Ошибка базы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void FilterByStationId(string stationName)
        {
            DoFormAction(() =>
            {
                supplyTable.Rows.Clear();
                foreach (var supply in Factory.GetSupplyRepository().GetSuppliesByStation(Factory.GetStationRepository().GetStationIdByName(stationName)))
                {
                    supplyTable.Rows.Add(supply.StationId, supply.StationName, supply.EmployeeName, supply.SupplyTypeId,
                        supply.SupplyTypeName, supply.SupplyTypeAmount, supply.SupplyDate);
                }
            });
        }

        public bool AddToSupplyTable(Supply sup)
        {
            bool checkFlag = false;
            try
            {
                if (SupplyValidator.CheckAddition(sup, out var errorList))
                {
                    Factory.GetSupplyRepository().AddToSupplyTable(sup);
                }
                else
                {
                    //int k = 0;
                    //foreach (string str in errorList)
                    //{
                    //    k++;
                    //    error += "Ошибка №" + k + ": " + str + " \n";
                    //}
                    //MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException e)
            {
                checkFlag = false;
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                checkFlag = false;
                MessageBox.Show("Невозможно выполнить операцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return checkFlag;
        }

        private string RemoveSpaces(string inputString)
        {
            inputString = inputString.Trim().Replace(" ", string.Empty);

            return inputString;
        }
    }
}
