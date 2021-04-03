using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IStaffRepository : IDisposable
    {
        List<Employee> GetStaff();

        void UpdateStaffTable(int id, Employee wk);

        void DeleteFromStaffTable(int id);

        void AddToStaffTable(Employee wk);

        string FindStaffByID(int staff_id);

        int FindStationIDByStaffID(int staff_id);

        List<int> FindStaffIDByStationID(int station_id);

    }
}
