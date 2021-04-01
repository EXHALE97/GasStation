using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;


namespace Queries.Repositories
{
    public class DealRepository : IDealRepository
    {
        private DataBaseConnection dbc;

        public DealRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }

        //public List<Deal> ShowDealTable()
        //{
        //    List<Deal> dealList = new List<Deal>();
        //    try
        //    {
        //        dbc.openConnection();
        //        NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Deal\"", dbc.getConnection());
        //        NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
        //        if (AZSTableReader.HasRows)
        //        {
        //            foreach (DbDataRecord dbDataRecord in AZSTableReader)
        //            {
        //                Deal deal = new Deal();

        //                deal.dealSet(Convert.ToInt32(dbDataRecord["deal_id"]), Convert.ToInt32(dbDataRecord["car_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
        //                    dbDataRecord["fueltype"].ToString(), Convert.ToInt32(dbDataRecord["fuelamount"]), Convert.ToInt32(dbDataRecord["dealprice"]),
        //                    dbDataRecord["cardnum"].ToString(), Convert.ToDateTime(dbDataRecord["dealdate"].ToString()));
        //                dealList.Add(deal);
        //            }
        //        }
        //        AZSTableReader.Close();
        //    }
        //    catch (PostgresException pe)
        //    {
        //        throw pe;
        //    }
        //    finally { dbc.closeConnection(); }

        //    return dealList;
        //}

        public List<Deal> ShowDealTable()
        {
            List<Deal> dealList = new List<Deal>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Deal\"");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Deal deal = new Deal();

                        deal.dealSet(Convert.ToInt32(dbDataRecord["deal_id"]), Convert.ToInt32(dbDataRecord["car_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fueltype"].ToString(), Convert.ToInt32(dbDataRecord["fuelamount"]), Convert.ToInt32(dbDataRecord["dealprice"]), Convert.ToDateTime(dbDataRecord["dealdate"].ToString()));
                        dealList.Add(deal);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dealList;
        }

        public List<Deal> ShowUserDealTable(int id)
        {
            List<Deal> dealList = new List<Deal>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Deal\" WHERE car_id = @Car_id");
                queryCommand.Parameters.AddWithValue("@Car_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Deal deal = new Deal();

                        deal.dealSet(Convert.ToInt32(dbDataRecord["deal_id"]), Convert.ToInt32(dbDataRecord["car_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fueltype"].ToString(), Convert.ToInt32(dbDataRecord["fuelamount"]), Convert.ToInt32(dbDataRecord["dealprice"]),
                            Convert.ToDateTime(dbDataRecord["dealdate"].ToString()));
                        dealList.Add(deal);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dealList;
        }

        public List<Deal> ShowWorkerDealTable(int id)
        {
            List<Deal> dealList = new List<Deal>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Deal\" WHERE staff_id = @Staff_id");
                queryCommand.Parameters.AddWithValue("@Staff_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Deal deal = new Deal();

                        deal.dealSet(Convert.ToInt32(dbDataRecord["deal_id"]), Convert.ToInt32(dbDataRecord["car_id"]), Convert.ToInt32(dbDataRecord["staff_id"]),
                            dbDataRecord["fueltype"].ToString(), Convert.ToInt32(dbDataRecord["fuelamount"]), Convert.ToInt32(dbDataRecord["dealprice"]),
                            Convert.ToDateTime(dbDataRecord["dealdate"]));
                        dealList.Add(deal);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dealList;
        }

        public List<Deal> GetDeals(Car car)
        {
            List<Deal> dgvElements = new List<Deal>();

            try
            {
                SqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT fueltype, fuelamount, dealprice, dealdate FROM \"AZS\".\"Deal\" WHERE car_id = @Car_id");
                //NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT fueltype, fuelamount, dealprice, dealdate FROM \"AZS\".\"Deal\" WHERE car_id = '" + car.GetCar_id() + "' ", dbc.getConnection());
                queryCommand.Parameters.AddWithValue("@Car_id", car.GetCarID());
                AZSTableReader = queryCommand.ExecuteReader();
                //NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Deal foundDeal = new Deal();
                        foundDeal.dealSet(dbDataRecord["fueltype"].ToString(), Convert.ToInt32(dbDataRecord["fuelamount"].ToString()),
                            Convert.ToInt32(dbDataRecord["dealprice"]), Convert.ToDateTime(dbDataRecord["dealdate"].ToString()));
                        dgvElements.Add(foundDeal);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dgvElements;
        }

        public void UpdateDealTable(int id, Deal deal)
        {
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("UPDATE \"AZS\".\"Deal\" SET car_id = @Car_id, fueltype = @Fueltype, fuelamount = @Fuelamount, dealprice = @DealPrice," +
                    "dealdate = @DealDate WHERE deal_id = @Deal_id ");
                queryCommand.Parameters.AddWithValue("@Car_id", deal.GetCarID());
                queryCommand.Parameters.AddWithValue("@Fueltype", deal.GetFuelType());
                queryCommand.Parameters.AddWithValue("@Fuelamount", deal.GetFuelAmount());
                queryCommand.Parameters.AddWithValue("@DealPrice", deal.GetDealPrice());
                queryCommand.Parameters.AddWithValue("@DealDate", deal.GetDealDate());
                queryCommand.Parameters.AddWithValue("@Deal_id", id);
                queryCommand.ExecuteNonQuery();

            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }
        }

        public void AddToDealTable(Deal deal)
        {
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Deal\"(Car_ID , Staff_ID , FuelType , FuelAmount , DealPrice , DealDate)" +
                        "VALUES(@Car_id, @Staff_id, @FuelType, @FuelAmount, @DealPrice, @DealDate)");
                queryCommand.Parameters.AddWithValue("@Car_id", deal.GetCarID());
                queryCommand.Parameters.AddWithValue("@Staff_id", deal.GetStaff_id());
                queryCommand.Parameters.AddWithValue("@FuelType", deal.GetFuelType());
                queryCommand.Parameters.AddWithValue("@FuelAmount", deal.GetFuelAmount());
                queryCommand.Parameters.AddWithValue("@DealPrice", deal.GetDealPrice());
                //queryCommand.Parameters.AddWithValue("@CardNum", deal.GetCardNum());
                queryCommand.Parameters.AddWithValue("@DealDate", Convert.ToDateTime(deal.GetDealDate()));
            queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }
        }

        public List<Deal> ShowBuyerDealTable(int id)
        {
            List<Deal> dgvElements = new List<Deal>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Deal\" WHERE car_id = @Car_id");
                queryCommand.Parameters.AddWithValue("@Car_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Deal deal = new Deal();
                        deal.dealSet(Convert.ToInt32(dbDataRecord["deal_id"]), Convert.ToInt32(dbDataRecord["car_id"]),
                            Convert.ToInt32(dbDataRecord["staff_id"]), dbDataRecord["fueltype"].ToString(),
                            Convert.ToInt32(dbDataRecord["fuelamount"]), Convert.ToInt32(dbDataRecord["dealprice"]),
                            Convert.ToDateTime(dbDataRecord["dealdate"].ToString()));
                        dgvElements.Add(deal);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return dgvElements;
        }
    }
}
