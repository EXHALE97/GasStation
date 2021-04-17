using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IDealRepository : IDisposable
    {
        List<Deal> GetDeals();

        List<Deal> GetDealsByClient(int clientId);

        List<Deal> GetDealsByEmployee(int employeeId);

        List<Deal> GetDealsByStation(int stationId);

        void UpdateDealTable(int id, Deal deal);

        void AddToDealTable(Deal deal);
    }
}
