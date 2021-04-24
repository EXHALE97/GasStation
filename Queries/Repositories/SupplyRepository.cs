using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class SupplyRepository : BaseRepository, ISupplyRepository
    {
        public SupplyRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {

        }

        public List<Supply> GetSupplies()
        {
            return ExecuteSqlCommand("EXEC SuppliesSummary", queryResult =>
            {
                var supplies = new List<Supply>();
                if (queryResult.HasRows)
                {
                    supplies.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Supply(int.Parse(dbDataRecord["station_id"].ToString()),
                            dbDataRecord["station_name"].ToString(),
                            int.Parse(dbDataRecord["employee_id"].ToString()),
                            dbDataRecord["employee_name"].ToString(),
                            int.Parse(dbDataRecord["supply_type_id"].ToString()),
                            dbDataRecord["supply_type_name"].ToString(),
                            double.Parse(dbDataRecord["supply_amount"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return supplies;
            });
        }

        public List<Supply> GetSuppliesByStation(int stationId)
        {
            return ExecuteSqlCommand($"EXEC SuppliesSummaryByStation {stationId}", queryResult =>
            {
                var supplies = new List<Supply>();
                if (queryResult.HasRows)
                {
                    supplies.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Supply(int.Parse(dbDataRecord["station_id"].ToString()),
                            dbDataRecord["station_name"].ToString(),
                            int.Parse(dbDataRecord["employee_id"].ToString()),
                            dbDataRecord["employee_name"].ToString(),
                            int.Parse(dbDataRecord["supply_type_id"].ToString()),
                            dbDataRecord["supply_type_name"].ToString(),
                            double.Parse(dbDataRecord["supply_amount"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return supplies;
            });
        }

        public List<Supply> GetSuppliesByEmployeeId(int employeeId)
        {
            return ExecuteSqlCommand($"EXEC SuppliesSummaryByEmployee {employeeId}", queryResult =>
            {
                var supplies = new List<Supply>();
                if (queryResult.HasRows)
                {
                    supplies.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Supply(int.Parse(dbDataRecord["station_id"].ToString()),
                            dbDataRecord["station_name"].ToString(),
                            int.Parse(dbDataRecord["employee_id"].ToString()),
                            dbDataRecord["employee_name"].ToString(),
                            int.Parse(dbDataRecord["supply_type_id"].ToString()),
                            dbDataRecord["supply_type_name"].ToString(),
                            double.Parse(dbDataRecord["supply_amount"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return supplies;
            });
        }

        public void AddToSupplyTable(Supply supply)
        {
            ExecuteSqlNonQueryCommand(
                $"EXEC InsertSupply {supply.StationId}, {supply.EmployeeId}, {supply.SupplyTypeId}, {supply.SupplyTypeAmount}, {supply.SupplyDate}");
        }
    }
}
