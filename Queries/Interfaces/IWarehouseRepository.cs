using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IWarehouseRepository
    {
        List<SupplyByStation> GetWarehouseInfo();

        List<SupplyByStation> GetWarehouseInfoByStationId(int id);

    }
}
