using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Entities;
using Queries.Factory;

namespace Queries.Controllers
{
    public class WarehouseController : BaseController
    {
        private readonly DataGridView table;

        public WarehouseController(DataGridView table, IRepositoryFactory factory)
        {
            Factory = factory;
            this.table = table;
        }

        public void ShowTable()
        {
            DoFormAction(() =>
            { 
                AddToTable(Factory.GetWarehouseRepository().GetWarehouseInfo());
            });
        }

        public void FilterTableByStationId(string stationName)
        {
            DoFormAction(() =>
            {
                AddToTable(Factory.GetWarehouseRepository().GetWarehouseInfoByStationId(Factory.GetStationRepository().GetStationIdByName(stationName)));
            });
        }

        private void AddToTable(IEnumerable<SupplyByStation> list)
        {
            table.Rows.Clear();
            foreach (var supplyByStation in list)
            {
                table.Rows.Add(supplyByStation.StationId, supplyByStation.StationName, supplyByStation.SupplyTypeId,
                    supplyByStation.SupplyTypeName, supplyByStation.SupplyTypeAmount);
            }
        }
    }
}
