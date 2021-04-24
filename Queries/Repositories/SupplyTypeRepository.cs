using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class SupplyTypeRepository : BaseRepository, ISupplyTypeRepository
    {
        public SupplyTypeRepository(DataBaseConnection connection)
        {
            DataBaseConnection = connection;
        }

        public void Dispose()
        {

        }

        public List<SupplyType> GetSupplyTypes()
        {
            return ExecuteSqlCommand("EXEC SupplyTypesSummary", queryResult =>
            {
                var types = new List<SupplyType>();
                if (queryResult.HasRows)
                {
                    types.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new SupplyType(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["name"].ToString(),
                            double.Parse(dbDataRecord["price"].ToString()),
                            bool.Parse(dbDataRecord["is_selling"].ToString())));
                }

                return types;
            });
        }

        public int GetSupplyTypeIdByName(string name)
        {
            return ExecuteSqlCommand($"EXEC GetSupplyTypeIdByName N'{name}'", queryResult =>
            {
                var supplyTypeId = 0;
                if (!queryResult.HasRows) return supplyTypeId;
                foreach (DbDataRecord dbDataRecord in queryResult)
                {
                    supplyTypeId = int.Parse(dbDataRecord["id"].ToString());
                }

                return supplyTypeId;
            });
        }

        public double GetSupplyTypePriceByName(string name)
        {
            return ExecuteSqlCommand($"EXEC GetSupplyTypePriceByName N'{name}'", queryResult =>
            {
                double price = 0;
                if (queryResult.HasRows)
                {
                    foreach (DbDataRecord dbDataRecord in queryResult)
                    {
                        price = double.Parse(dbDataRecord[0].ToString());
                    }
                }

                return price;
            });
        }

        public void AddSupplyType(SupplyType supplyType)
        {
            ExecuteSqlNonQueryCommand($"EXEC AddSupplyType N'{supplyType.Name}', {supplyType.Price}, '{supplyType.IsSelling.ToString()}'");
        }

        public void UpdateSupplyType(SupplyType supplyType)
        {
            ExecuteSqlNonQueryCommand($"EXEC UpdateSupplyType {supplyType.Id}, N'{supplyType.Name}', {supplyType.Price}, '{supplyType.IsSelling.ToString()}'");
        }

        public void DeleteSupplyType(int id)
        {
            ExecuteSqlNonQueryCommand($"EXEC DeleteSupplyType {id}");
        }
    }
}