using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {

        }

        public List<Employee> GetEmployees(bool workingOnly)
        {
            return ExecuteSqlCommand(workingOnly ? "EXEC WorkingEmployeesSummary" : "EXEC EmployeesSummary", queryResult =>
            {
                var employeeList = new List<Employee>();
                if (queryResult.HasRows)
                {
                    employeeList.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new Employee(int.Parse(dbDataRecord["id"].ToString()), int.Parse(dbDataRecord["cred_id"].ToString()),
                            dbDataRecord["last_name"].ToString(), dbDataRecord["first_name"].ToString(), dbDataRecord["middle_name"].ToString(),
                            dbDataRecord["position"].ToString(), Convert.ToDateTime(dbDataRecord["date_of_birth"].ToString()), 
                            Convert.ToDateTime(dbDataRecord["date_of_employment"].ToString()), 
                            Convert.ToDateTime(dbDataRecord["date_of_contract_end"].ToString()), double.Parse(dbDataRecord["salary"].ToString()), 
                            dbDataRecord["address"].ToString(), dbDataRecord["phone"].ToString(), bool.Parse(dbDataRecord["is_working"].ToString())));
                }
                
                queryResult.Close();
                return employeeList;
            });
        }

        public void AddToEmployeeTable(Employee employee)
        {
            ExecuteSqlNonQueryCommand(
                "INSERT INTO \"AZS\".\"Staff\"(Station_id, Surname, Name, Gender, Birthdate, Function, Salary)" +
                "VALUES(@Station_id, @Surname, @Name, @Gender, @Birthdate, @Function, @Salary)");
        }

        public void UpdateEmployeeTable(int id, Employee employee)
        {
            ExecuteSqlNonQueryCommand(
                "INSERT INTO \"AZS\".\"Staff\"(Station_id, Surname, Name, Gender, Birthdate, Function, Salary)" +
                "VALUES(@Station_id, @Surname, @Name, @Gender, @Birthdate, @Function, @Salary)");
        }

        public void DeleteFromEmployeeTable(int id)
        {
            ExecuteSqlNonQueryCommand(
                "INSERT INTO \"AZS\".\"Staff\"(Station_id, Surname, Name, Gender, Birthdate, Function, Salary)" +
                "VALUES(@Station_id, @Surname, @Name, @Gender, @Birthdate, @Function, @Salary)");
        }

        public string FindEmployeeById(int id)
        {
            string SName = String.Empty, name, surname;
            try
            {
                SqlDataReader AZSTableReader = null;
                DataBaseConnection.OpenConnection();
                var queryCommand = new SqlCommand("SELECT surname, name FROM \"AZS\".\"Staff\" WHERE staff_id = @Staff_id ");
                queryCommand.Parameters.AddWithValue("@Staff_id", id);
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
            finally { DataBaseConnection.CloseConnection(); }

            return SName;
        }
    }
}
