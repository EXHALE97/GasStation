using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ISupplyTypeRepository : IDisposable
    {
        List<SupplyType> GetSupplyTypes();

        int GetSupplyTypeIdByName(string name);

        double GetSupplyTypePriceByName(string name);

        void AddSupplyType(SupplyType supplyType);

        void UpdateSupplyType(SupplyType supplyType);

        void DeleteSupplyType(int id);
    }
}