using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ISupplyRepository : IDisposable
    {
        List<Supply> ShowSupplyTable();

        void AddToSupplyTable(Supply sup);

        List<Supply> ShowSupplyTableByID(int ID);

        List<Supply> GetSupplyBYStationID(int id);

    }
}
