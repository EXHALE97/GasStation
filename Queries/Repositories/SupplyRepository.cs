using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class SupplyRepository : ISupplyRepository
    {
        private DataBaseConnection dbc;

        public SupplyRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }

        public List<Supply> ShowSupplyTable()
        {
            List<Supply> supplyList = new List<Supply>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Supply\"");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Supply supply = new Supply();

                        supply.supplySet(Convert.ToInt32(dbDataRecord["station_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fuelsupplytype"].ToString(), Convert.ToInt32(dbDataRecord["fuelsupplyamount"]),
                            Convert.ToDateTime(dbDataRecord["supplydate"].ToString()));
                        supplyList.Add(supply);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return supplyList;
        }

        public void AddToSupplyTable(Supply sup)
        {
            try
            {
                dbc.OpenConnection();
                    var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Supply\"(Station_ID, Staff_ID, FuelSupplyType, FuelSupplyAmount, SupplyDate)" +
                                                      "VALUES(@Station_id, @Staff_id, @FuelSupplyType, @FuelSupplyAmount, @SupplyDate)");
                    queryCommand.Parameters.AddWithValue("@Station_id", sup.GetStationID());
                    queryCommand.Parameters.AddWithValue("@Staff_id", sup.GetStaffID());
                    queryCommand.Parameters.AddWithValue("@FuelSupplyType", sup.GetFuelSupplyType());
                    queryCommand.Parameters.AddWithValue("@FuelSupplyAmount", sup.GetFuelSupplyAmount());
                    queryCommand.Parameters.AddWithValue("@SupplyDate", sup.GetSupplyDate());

                queryCommand.ExecuteNonQuery();
                dbc.CloseConnection(); 
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

        }

        public List<Supply> ShowSupplyTableByID(int ID)
        {
            List<Supply> supplyList = new List<Supply>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id");
                queryCommand.Parameters.AddWithValue("@Station_id", ID);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Supply supply = new Supply();

                        supply.supplySet(Convert.ToInt32(dbDataRecord["station_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fuelsupplytype"].ToString(), Convert.ToInt32(dbDataRecord["fuelsupplyamount"]),
                            Convert.ToDateTime(dbDataRecord["supplydate"].ToString()));
                        supplyList.Add(supply);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return supplyList;
        }

        public List<Supply> GetSupplyBYStationID(int id)
        {
            List<Supply> supplyList = new List<Supply>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id ORDER BY supplydate");
                queryCommand.Parameters.AddWithValue("@Station_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Supply supply = new Supply();

                        supply.supplySet(Convert.ToInt32(dbDataRecord["station_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fuelsupplytype"].ToString(), Convert.ToInt32(dbDataRecord["fuelsupplyamount"]),
                            Convert.ToDateTime(dbDataRecord["supplydate"].ToString()));
                        supplyList.Add(supply);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return supplyList;
        }
    }
}
