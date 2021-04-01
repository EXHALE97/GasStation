using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Supply\"", dbc.GetConnection());
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
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
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return supplyList;
        }

        public void AddToSupplyTable(Supply sup)
        {
            NpgsqlCommand queryCommand;
            try
            {
                dbc.OpenConnection();
                    queryCommand = new NpgsqlCommand("INSERT INTO \"AZS\".\"Supply\"(Station_ID, Staff_ID, FuelSupplyType, FuelSupplyAmount, SupplyDate)" +
                        "VALUES(@Station_id, @Staff_id, @FuelSupplyType, @FuelSupplyAmount, @SupplyDate)", dbc.GetConnection());
                    queryCommand.Parameters.AddWithValue("@Station_id", sup.GetStationID());
                    queryCommand.Parameters.AddWithValue("@Staff_id", sup.GetStaffID());
                    queryCommand.Parameters.AddWithValue("@FuelSupplyType", sup.GetFuelSupplyType());
                    queryCommand.Parameters.AddWithValue("@FuelSupplyAmount", sup.GetFuelSupplyAmount());
                    queryCommand.Parameters.AddWithValue("@SupplyDate", sup.GetSupplyDate());

                queryCommand.ExecuteNonQuery();
                dbc.CloseConnection(); 
            }
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Station_id", ID);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
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
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Supply\" WHERE station_id = @Station_id ORDER BY supplydate", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Station_id", id);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
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
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return supplyList;
        }
    }
}
