using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class CarRepository : ICarRepository
    {
        private DataBaseConnection dbc;

        public CarRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }

        public List<Car> GetCars()
        {
            List<Car> dgvElements = new List<Car>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Car\"");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Car buyerCar = new Car();
                        buyerCar.buyerSet(Convert.ToInt32(dbDataRecord["car_id"]), dbDataRecord["carmark"].ToString(), dbDataRecord["cardnum"].ToString());
                        dgvElements.Add(buyerCar);
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

        public int FindCarIDByCardnum(string cardnum)
        {
            int car_id = 0;
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT car_id FROM \"AZS\".\"Car\" WHERE cardnum = @Cardnum");
                queryCommand.Parameters.AddWithValue("@CardNum", cardnum);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        car_id = Convert.ToInt32(dbDataRecord["car_id"]);
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return car_id;
        }

        public string FindCardNumByCarID(int id)
        {
            string cardnum = String.Empty;
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT cardnum FROM \"AZS\".\"Car\" WHERE car_id = @Car_id");
                queryCommand.Parameters.AddWithValue("@Car_id", id);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        cardnum = dbDataRecord["cardnum"].ToString();
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return cardnum;
        }


        public List<string> GetCardNumList()
        {
            List<string> comboBoxElements = new List<string>();

            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT DISTINCT cardnum FROM \"AZS\".\"Car\"");
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        comboBoxElements.Add(dbDataRecord["cardnum"].ToString());
                    }
                }
                AZSTableReader.Close();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return comboBoxElements;
        }

        public void AddToCarTable(Car car)
        {
            try
            {
                dbc.OpenConnection();

                var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Car\"(carmark, cardnum)" +
                                                  "VALUES(@carmark, @cardnum)");
                queryCommand.Parameters.AddWithValue("@carmark", car.GetCarMark());
                queryCommand.Parameters.AddWithValue("@cardnum", car.GetCardNum());

                queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

        }
    }
}
