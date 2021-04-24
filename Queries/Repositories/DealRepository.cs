using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;


namespace Queries.Repositories
{
    public class DealRepository : BaseRepository, IDealRepository
    {
        public DealRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {

        }

        public List<Deal> GetDeals()
        {
            return ExecuteSqlCommand("EXEC DealsSummary", queryResult =>
            {
                var deals = new List<Deal>();
                if (queryResult.HasRows)
                {

                    deals.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Deal(int.Parse(dbDataRecord["id"].ToString()),
                            int.Parse(dbDataRecord["card_id"].ToString()),
                            dbDataRecord["client_data"].ToString(),
                            dbDataRecord["employee_data"].ToString(),
                            dbDataRecord["station_name"].ToString(),
                            dbDataRecord["supply_type"].ToString(),
                            double.Parse(dbDataRecord["supply_type_amount"].ToString()),
                            int.Parse(dbDataRecord["discount_percent"].ToString()),
                            double.Parse(dbDataRecord["price"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return deals;
            });
        }

        public List<Deal> GetDealsByClient(int clientId)
        {
            return ExecuteSqlCommand($"EXEC GetDealsByClient {clientId}", queryResult =>
            {
                var deals = new List<Deal>();
                if (queryResult.HasRows)
                {

                    deals.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Deal(int.Parse(dbDataRecord["id"].ToString()),
                            int.Parse(dbDataRecord["card_id"].ToString()),
                            dbDataRecord["client_data"].ToString(),
                            dbDataRecord["employee_data"].ToString(),
                            dbDataRecord["station_name"].ToString(),
                            dbDataRecord["supply_type"].ToString(),
                            double.Parse(dbDataRecord["supply_type_amount"].ToString()),
                            int.Parse(dbDataRecord["discount_percent"].ToString()),
                            double.Parse(dbDataRecord["price"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return deals;
            });
        }

        public List<Deal> GetDealsByEmployee(int employeeId)
        {
            return ExecuteSqlCommand($"EXEC GetDealsByEmployee {employeeId}", queryResult =>
            {
                var deals = new List<Deal>();
                if (queryResult.HasRows)
                {

                    deals.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Deal(int.Parse(dbDataRecord["id"].ToString()),
                            int.Parse(dbDataRecord["card_id"].ToString()),
                            dbDataRecord["client_data"].ToString(),
                            dbDataRecord["employee_data"].ToString(),
                            dbDataRecord["station_name"].ToString(),
                            dbDataRecord["supply_type"].ToString(),
                            double.Parse(dbDataRecord["supply_type_amount"].ToString()),
                            int.Parse(dbDataRecord["discount_percent"].ToString()),
                            double.Parse(dbDataRecord["price"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return deals;
            });
        }

        public List<Deal> GetDealsByStation(int stationId)
        {
            return ExecuteSqlCommand($"EXEC GetDealsByStation {stationId}", queryResult =>
            {
                var deals = new List<Deal>();
                if (queryResult.HasRows)
                {

                    deals.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Deal(int.Parse(dbDataRecord["id"].ToString()),
                            int.Parse(dbDataRecord["card_id"].ToString()),
                            dbDataRecord["client_data"].ToString(),
                            dbDataRecord["employee_data"].ToString(),
                            dbDataRecord["station_name"].ToString(),
                            dbDataRecord["supply_type"].ToString(),
                            double.Parse(dbDataRecord["supply_type_amount"].ToString()),
                            int.Parse(dbDataRecord["discount_percent"].ToString()),
                            double.Parse(dbDataRecord["price"].ToString()),
                            Convert.ToDateTime(dbDataRecord["date"].ToString())));
                }

                queryResult.Close();
                return deals;
            });
        }

        public void UpdateDealTable(Deal deal)
        {
            //не конвертится время (всегда 12:00 пишет)
            ExecuteSqlNonQueryCommand(
                $"EXEC UpdateDealShort {deal.Id}, {deal.ClientCardId}, N'{deal.SupplyType}', {deal.SupplyTypeAmount}, '{deal.Date.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture)}'");
        }

        public void AddToDealTable(Deal deal)
        {
            ExecuteSqlNonQueryCommand(
                $"EXEC InsertDeal {deal.ClientCardId}, {deal.EmployeeId}, N'{deal.Station}', N'{deal.SupplyType}', {deal.SupplyTypeAmount}, '{deal.Date.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture)}'");
        }
    }
}
