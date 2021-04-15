using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IDealRepository : IDisposable
    {
        List<Deal> ShowDealTable();

        List<Deal> ShowUserDealTable(int id);

        List<Deal> ShowWorkerDealTable(int id);

        List<Deal> GetDeals(Client car);

        void UpdateDealTable(int id, Deal deal);

        List<Deal> GetDealsForClient(int clientId);

        void AddToDealTable(Deal deal);

    }
}
