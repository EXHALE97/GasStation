using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IStaffRepository : IDisposable
    {
        List<Worker> GetStaff();

        void UpdateStaffTable(int id, Worker wk);

        void DeleteFromStaffTable(int id);

        void AddToStaffTable(Worker wk);

        string FindStaffByID(int staff_id);

        int FindStationIDByStaffID(int staff_id);

        List<int> FindStaffIDByStationID(int station_id);

    }
}
