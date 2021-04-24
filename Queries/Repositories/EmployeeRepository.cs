using System;
using System.Collections.Generic;
using System.Data.Common;
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
                        select new Employee(int.Parse(dbDataRecord["id"].ToString()), 
                            dbDataRecord["cred_id"].ToString() == string.Empty ? 0 : int.Parse(dbDataRecord["cred_id"].ToString()),
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
            if (employee.CredId == 0 && employee.MiddleName == null)
            {
                ExecuteSqlNonQueryCommand($"EXEC InsertEmployee N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'");
            }
            else if (employee.CredId != 0 && employee.MiddleName == null)
            {
                ExecuteSqlNonQueryCommand($"EXEC InsertEmployee N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"'{employee.CredId}'");
            }
            else if (employee.CredId == 0 && employee.MiddleName != null)
            {
                ExecuteSqlNonQueryCommand($"EXEC InsertEmployee N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"NULL, N'{employee.MiddleName}'");
            }
            else
            {
                ExecuteSqlNonQueryCommand($"EXEC InsertEmployee N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"'{employee.CredId}', N'{employee.MiddleName}'");
            }
            
        }

        public void UpdateEmployeeTable(int id, Employee employee)
        {
            if (employee.CredId == 0 && employee.MiddleName == null)
            {
                ExecuteSqlNonQueryCommand($"EXEC UpdateEmployee '{id}', N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'");
            }
            else if (employee.CredId != 0 && employee.MiddleName == null)
            {
                ExecuteSqlNonQueryCommand($"EXEC UpdateEmployee '{id}', N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"'{employee.CredId}'");
            }
            else if (employee.CredId == 0 && employee.MiddleName != null)
            {
                ExecuteSqlNonQueryCommand($"EXEC UpdateEmployee '{id}', N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"NULL, N'{employee.MiddleName}'");
            }
            else
            {
                ExecuteSqlNonQueryCommand($"EXEC UpdateEmployee '{id}', N'{employee.Name}', N'{employee.SurName}', N'{employee.Position}'," +
                                          $"'{employee.Birthday:d}', '{employee.EmploymentDate:d}', '{employee.ContractEndDate:d}'," +
                                          $"'{employee.Salary}', N'{employee.Address}', N'{employee.Phone}', '{employee.IsWorking.ToString()}'," +
                                          $"'{employee.CredId}', N'{employee.MiddleName}'");
            }
        }

        public void SetEmployeeCredentials(int employeeId, Credentials credentials)
        {
            ExecuteSqlNonQueryCommand(
                $"EXEC InsertCredentialsAndConnectToEmployee '{employeeId}', '{credentials.Login}', '{credentials.Password}', '{credentials.Role}'");
        }

        public void DeleteFromEmployeeTable(int id)
        {
            ExecuteSqlNonQueryCommand($"EXEC DeleteEmployee '{id}'");
        }

        public string GetEmployeeFullNameById(int id)
        {
            return ExecuteSqlCommand($"SELECT dbo.GetEmployeeFullName({id})", queryResult =>
            {
                var fullName = string.Empty;
                if (!queryResult.HasRows) return fullName;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    fullName = dbDataRecord[0].ToString();
                }

                return fullName;
            });
        }
    }
}
