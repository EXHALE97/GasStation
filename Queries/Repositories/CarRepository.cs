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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Car\"", dbc.GetConnection());
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
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
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT car_id FROM \"AZS\".\"Car\" WHERE cardnum = @Cardnum", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@CardNum", cardnum);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        car_id = Convert.ToInt32(dbDataRecord["car_id"]);
                    }
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT cardnum FROM \"AZS\".\"Car\" WHERE car_id = @Car_id", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Car_id", id);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        cardnum = dbDataRecord["cardnum"].ToString();
                    }
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
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
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT DISTINCT cardnum FROM \"AZS\".\"Car\"", dbc.GetConnection());
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        comboBoxElements.Add(dbDataRecord["cardnum"].ToString());
                    }
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return comboBoxElements;
        }

        public void AddToCarTable(Car car)
        {
            NpgsqlCommand queryCommand;
            try
            {
                dbc.OpenConnection();

                queryCommand = new NpgsqlCommand("INSERT INTO \"AZS\".\"Car\"(carmark, cardnum)" +
                "VALUES(@carmark, @cardnum)", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@carmark", car.GetCarMark());
                queryCommand.Parameters.AddWithValue("@cardnum", car.GetCardNum());

                queryCommand.ExecuteNonQuery();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

        }
    }
}
