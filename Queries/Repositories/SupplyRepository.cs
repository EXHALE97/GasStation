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

        public void AddToSupplyTable(Supply sup)
        {
            //try
            //{
            //    dbc.OpenConnection();
            //        var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Supply\"(Station_ID, Staff_ID, FuelSupplyType, FuelSupplyAmount, SupplyDate)" +
            //                                          "VALUES(@Station_id, @Staff_id, @FuelSupplyType, @FuelSupplyAmount, @SupplyDate)");
            //        queryCommand.Parameters.AddWithValue("@Station_id", sup.GetStationID());
            //        queryCommand.Parameters.AddWithValue("@Staff_id", sup.GetStaffID());
            //        queryCommand.Parameters.AddWithValue("@FuelSupplyType", sup.GetFuelSupplyType());
            //        queryCommand.Parameters.AddWithValue("@FuelSupplyAmount", sup.GetFuelSupplyAmount());
            //        queryCommand.Parameters.AddWithValue("@SupplyDate", sup.GetSupplyDate());

            //    queryCommand.ExecuteNonQuery();
            //    dbc.CloseConnection(); 
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

        }

        public List<Supply> ShowSupplyTableByID(int ID)
        {
            List<Supply> supplyList = new List<Supply>();
            //try
            //{
            //    dbc.OpenConnection();
            //    var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id");
            //    queryCommand.Parameters.AddWithValue("@Station_id", ID);
            //    var AZSTableReader = queryCommand.ExecuteReader();
            //    if (AZSTableReader.HasRows)
            //    {
            //        foreach (DbDataRecord dbDataRecord in AZSTableReader)
            //        {
            //            Supply supply = new Supply();

            //            supply.supplySet(Convert.ToInt32(dbDataRecord["station_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
            //                dbDataRecord["fuelsupplytype"].ToString(), Convert.ToInt32(dbDataRecord["fuelsupplyamount"]),
            //                Convert.ToDateTime(dbDataRecord["supplydate"].ToString()));
            //            supplyList.Add(supply);
            //        }
            //    }
            //    AZSTableReader.Close();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

            return supplyList;
        }

        public List<Supply> GetSupplyBYStationID(int id)
        {
            List<Supply> supplyList = new List<Supply>();
            //try
            //{
            //    dbc.OpenConnection();
            //    var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id ORDER BY supplydate");
            //    queryCommand.Parameters.AddWithValue("@Station_id", id);
            //    var AZSTableReader = queryCommand.ExecuteReader();
            //    if (AZSTableReader.HasRows)
            //    {
            //        foreach (DbDataRecord dbDataRecord in AZSTableReader)
            //        {
            //            Supply supply = new Supply();

            //            supply.supplySet(Convert.ToInt32(dbDataRecord["station_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
            //                dbDataRecord["fuelsupplytype"].ToString(), Convert.ToInt32(dbDataRecord["fuelsupplyamount"]),
            //                Convert.ToDateTime(dbDataRecord["supplydate"].ToString()));
            //            supplyList.Add(supply);
            //        }
            //    }
            //    AZSTableReader.Close();
            //}
            //catch (SqlException pe)
            //{
            //    throw pe;
            //}
            //finally { dbc.CloseConnection(); }

            return supplyList;
        }

        public List<SupplyType> GetSupplyTypes()
        {
            return ExecuteSqlCommand("EXEC SupplyTypesSummary", queryResult =>
            {
                var types = new List<SupplyType>();
                if (queryResult.HasRows)
                {
                    types.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new SupplyType(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["name"].ToString(),
                            double.Parse(dbDataRecord["price"].ToString()),
                            bool.Parse(dbDataRecord["is_selling"].ToString())));
                }

                return types;
            });
        }
    }
}
