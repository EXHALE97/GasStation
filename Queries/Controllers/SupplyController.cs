using System.Linq;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;
using Queries.Support.MessageBox;
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

        public void ShowEmployeeTable(int employeeId)
        {
            DoFormAction(() =>
            {
                supplyTable.Rows.Clear();
                foreach (var supply in Factory.GetSupplyRepository().GetSuppliesByEmployeeId(employeeId))
                {
                    supplyTable.Rows.Add(supply.StationName, supply.SupplyTypeName, supply.SupplyTypeAmount, supply.SupplyDate);
                }
            });
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

        public bool AddToSupplyTable(Supply supply)
        {
            return DoFormAction(() =>
            {
                if (SupplyValidator.CheckAddition(supply, out var errorList))
                {
                    Factory.GetSupplyRepository().AddToSupplyTable(supply);
                    return true;
                }

                ErrorMessageBox.ShowCustomErrorMessage(errorList.Aggregate(string.Empty,
                    (current, error) => current + "Ошибка №" + errorList.IndexOf(error) + ": " + error + " \n"));

                return false;
            });
        }
    }
}
