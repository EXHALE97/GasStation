using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IEmployeeRepository : IDisposable
    {
        List<Employee> GetEmployees(bool workingOnly);

        void UpdateEmployeeTable(int id, Employee employee);

        void SetEmployeeCredentials(int employeeId, Credentials credentials);

        void DeleteFromEmployeeTable(int id);

        void AddToEmployeeTable(Employee employee);

        string FindEmployeeById(int id);
    }
}
