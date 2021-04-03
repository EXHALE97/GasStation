using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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

        public List<Employee> GetStaff()
        {
            List<Employee> dgvElements = new List<Employee>();
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT * FROM \"AZS\".\"Staff\"" + " EXCEPT " + 
                    "SELECT * FROM \"AZS\".\"Staff\" WHERE function = " + "@DismissedFunction" + " OR salary = @DismissedSalary");
                queryCommand.Parameters.AddWithValue("@DismissedFunction", "Уволен!");
                queryCommand.Parameters.AddWithValue("@DismissedSalary", 0);
                var AZSTableReader = queryCommand.ExecuteReader();
                if (AZSTableReader.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in AZSTableReader)
                    {
                        Employee wk = new Employee();

                            wk.workerSet(Convert.ToInt32(dbDataRecord["staff_id"]), Convert.ToInt32(dbDataRecord["station_id"]), dbDataRecord["surname"].ToString(),
                                dbDataRecord["name"].ToString(), dbDataRecord["gender"].ToString(), Convert.ToDateTime(dbDataRecord["birthdate"]),
                                dbDataRecord["function"].ToString(), Convert.ToInt32(dbDataRecord["salary"]));

                            dgvElements.Add(wk);
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

        public void AddToStaffTable(Employee wk)
        {
            try
            {
                dbc.OpenConnection();

                    var queryCommand = new SqlCommand("INSERT INTO \"AZS\".\"Staff\"(Station_id, Surname, Name, Gender, Birthdate, Function, Salary)" +
                        "VALUES(@Station_id, @Surname, @Name, @Gender, @Birthdate, @Function, @Salary)");
                    queryCommand.Parameters.AddWithValue("@Station_id", wk.GetStationID());
                    queryCommand.Parameters.AddWithValue("@Surname", wk.GetSurname());
                    queryCommand.Parameters.AddWithValue("@Name", wk.GetName());
                    queryCommand.Parameters.AddWithValue("@Gender", wk.GetGender());
                    queryCommand.Parameters.AddWithValue("@Birthdate", wk.GetBirthdate());
                    queryCommand.Parameters.AddWithValue("@Function", wk.GetFunction());
                    queryCommand.Parameters.AddWithValue("@Salary", wk.GetSalary());
                    queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
            {
                throw pe;
            }       
            finally { dbc.CloseConnection(); }

        }

        public void UpdateStaffTable(int id, Employee wk)
        {
            try
            {
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("UPDATE \"AZS\".\"Staff\" SET surname = @Surname, name = @Name, function = @Function, " +
                "salary = @Salary WHERE staff_id = @Staff_id ");

                queryCommand.Parameters.AddWithValue("@Surname", wk.GetSurname());
                queryCommand.Parameters.AddWithValue("@Name", wk.GetName());
                queryCommand.Parameters.AddWithValue("@Function", wk.GetFunction());
                queryCommand.Parameters.AddWithValue("@Salary", wk.GetSalary());
                queryCommand.Parameters.AddWithValue("@Staff_id", id);

                queryCommand.ExecuteNonQuery();
            }
            catch (SqlException pe)
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
                var queryCommand = new SqlCommand("UPDATE \"AZS\".\"Staff\" SET  function = @DismissedFunction, salary = @DismissedSalary WHERE staff_id = @Staff_id ");
                queryCommand.Parameters.AddWithValue("@Staff_id", id);
                queryCommand.Parameters.AddWithValue("@DismissedFunction", "Уволен!");
                queryCommand.Parameters.AddWithValue("@DismissedSalary", 0);
                queryCommand.ExecuteNonQuery();

            }
            catch (SqlException pe)
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
                SqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT surname, name FROM \"AZS\".\"Staff\" WHERE staff_id = @Staff_id ");
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
            catch (SqlException pe)
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
                SqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT station_id FROM \"AZS\".\"Staff\" WHERE staff_id = @Staff_id ");
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
            catch (SqlException pe)
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
                SqlDataReader AZSTableReader = null;
                dbc.OpenConnection();
                var queryCommand = new SqlCommand("SELECT staff_id FROM \"AZS\".\"Staff\" WHERE station_id = @Station_id ");
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
            catch (SqlException pe)
            {
                throw pe;
            }
            finally { dbc.CloseConnection(); }

            return staff_id;
        }
    }
}
