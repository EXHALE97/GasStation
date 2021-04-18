using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class WarehouseRepository : BaseRepository, IWarehouseRepository
    {
        public WarehouseRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public List<SupplyByStation> GetWarehouseInfo()
        {
            return ExecuteSqlCommand("EXEC SupplyByStationSummary", queryResult =>
            {
                var list = new List<SupplyByStation>();
                if (queryResult.HasRows)
                {
                    list.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new SupplyByStation(int.Parse(dbDataRecord["station_id"].ToString()),
                            dbDataRecord["station_name"].ToString(),
                            int.Parse(dbDataRecord["supply_type_id"].ToString()),
                            dbDataRecord["supply_type_name"].ToString(),
                            double.Parse(dbDataRecord["supply_count"].ToString())));
                }

                queryResult.Close();
                return list;
            });
        }

        public List<SupplyByStation> GetWarehouseInfoByStationId(int stationId)
        {
            return ExecuteSqlCommand($"EXEC GetSupplyAmountByStationId {stationId}", queryResult =>
            {
                var list = new List<SupplyByStation>();
                if (queryResult.HasRows)
                {
                    list.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new SupplyByStation(int.Parse(dbDataRecord["station_id"].ToString()),
                            dbDataRecord["station_name"].ToString(),
                            int.Parse(dbDataRecord["supply_type_id"].ToString()),
                            dbDataRecord["supply_type_name"].ToString(),
                            double.Parse(dbDataRecord["supply_count"].ToString())));
                }

                queryResult.Close();
                return list;
            });
        }
    }
}
