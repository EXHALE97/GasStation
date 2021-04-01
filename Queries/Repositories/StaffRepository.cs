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
    public class StaffRepository : IStaffRepository
    {
        private DataBaseConnection dbc;

        public StaffRepository(DataBaseConnection dbc)
        {
            this.dbc = dbc;
        }

        public void Dispose()
        {

        }

        public List<Worker> GetStaff()
        {
            List<Worker> dgvElements = new List<Worker>();
            try
            {
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT * FROM \"AZS\".\"Staff\"" + " EXCEPT " + 
                    "SELECT * FROM \"AZS\".\"Staff\" WHERE function = " + "@DismissedFunction" + " OR salary = @DismissedSalary", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@DismissedFunction", "Уволен!");
                queryCommand.Parameters.AddWithValue("@DismissedSalary", 0);
                NpgsqlDataReader AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Worker wk = new Worker();

                            wk.workerSet(Convert.ToInt32(dbDataRecord["staff_id"]), Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["surname"].ToString(),
                                dbDataRecord["name"].ToString(), dbDataRecord["gender"].ToString(), Convert.ToDateTime(dbDataRecord["birthdate"]),
                                dbDataRecord["function"].ToString(), Convert.ToInt32(dbDataRecord["salary"]));

                            dgvElements.Add(wk);
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

        public void AddToStaffTable(Worker wk)
        {
            try
            {
                dbc.OpenConnection();

                    NpgsqlCommand queryCommand = new NpgsqlCommand("INSERT INTO \"AZS\".\"Staff\"(Station_id, Surname, Name, Gender, Birthdate, Function, Salary)" +
                        "VALUES(@Station_id, @Surname, @Name, @Gender, @Birthdate, @Function, @Salary)", dbc.GetConnection());
                    queryCommand.Parameters.AddWithValue("@Station_id", wk.GetStationID());
                    queryCommand.Parameters.AddWithValue("@Surname", wk.GetSurname());
                    queryCommand.Parameters.AddWithValue("@Name", wk.GetName());
                    queryCommand.Parameters.AddWithValue("@Gender", wk.GetGender());
                    queryCommand.Parameters.AddWithValue("@Birthdate", wk.GetBirthdate());
                    queryCommand.Parameters.AddWithValue("@Function", wk.GetFunction());
                    queryCommand.Parameters.AddWithValue("@Salary", wk.GetSalary());
                    queryCommand.ExecuteNonQuery();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }       
            finally { dbc.CloseConnection(); }

        }

        public void UpdateStaffTable(int id, Worker wk)
        {
            try
            {
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("UPDATE \"AZS\".\"Staff\" SET surname = @Surname, name = @Name, function = @Function, " +
                "salary = @Salary WHERE staff_id = @Staff_id ", dbc.GetConnection());

                queryCommand.Parameters.AddWithValue("@Surname", wk.GetSurname());
                queryCommand.Parameters.AddWithValue("@Name", wk.GetName());
                queryCommand.Parameters.AddWithValue("@Function", wk.GetFunction());
                queryCommand.Parameters.AddWithValue("@Salary", wk.GetSalary());
                queryCommand.Parameters.AddWithValue("@Staff_id", id);

                queryCommand.ExecuteNonQuery();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

        }

        public void DeleteFromStaffTable(int id)
        {
            try
            {
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("UPDATE \"AZS\".\"Staff\" SET  function = @DismissedFunction, salary = @DismissedSalary WHERE staff_id = @Staff_id ", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Staff_id", id);
                queryCommand.Parameters.AddWithValue("@DismissedFunction", "Уволен!");
                queryCommand.Parameters.AddWithValue("@DismissedSalary", 0);
                queryCommand.ExecuteNonQuery();

            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

        }

        public string FindStaffByID(int staff_id)
        {
            string SName = String.Empty, name, surname;
            try
            {
                NpgsqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT surname, name FROM \"AZS\".\"Staff\" WHERE staff_id = @Staff_id ", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Staff_id", staff_id);
                AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        surname = dbDataRecord["surname"].ToString().Replace(" ", string.Empty);
                        name = dbDataRecord["name"].ToString().Replace(" ", string.Empty);
                        SName = surname + " " + name;
                    }               
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return SName;
        }

        public int FindStationIDByStaffID(int staff_id)
        {
            int station_id = 0;
            try
            {
                NpgsqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT station_id FROM \"AZS\".\"Staff\" WHERE staff_id = @Staff_id ", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Staff_id", staff_id);
                AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        station_id = Convert.ToInt32(dbDataRecord["station_id"]);
                    }
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return station_id;
        }

        public List<int> FindStaffIDByStationID(int station_id)
        {
            List<int> staff_id = new List<int>();
            try
            {             
                NpgsqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                NpgsqlCommand queryCommand = new NpgsqlCommand("SELECT staff_id FROM \"AZS\".\"Staff\" WHERE station_id = @Station_id ", dbc.GetConnection());
                queryCommand.Parameters.AddWithValue("@Station_id", station_id);
                AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        staff_id.Add(Convert.ToInt32(dbDataRecord["staff_id"]));
                    }
                }
                AZSTableReader.Close();
            }
            catch (PostgresException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return staff_id;
        }
    }
}
