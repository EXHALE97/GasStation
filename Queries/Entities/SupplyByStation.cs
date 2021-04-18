using System;

namespace Queries.Entities
{
    public class SupplyByStation
    {
        public int StationId { get; }
        public string StationName { get; }
        public int SupplyTypeId { get; }
        public string SupplyTypeName { get; }
        public double SupplyTypeAmount { get; }

        public SupplyByStation(int stationId, string stationName, int supplyTypeId, string supplyTypeName,
            double supplyTypeAmount)
        {
            StationId = stationId;
            StationName = stationName;
            SupplyTypeId = supplyTypeId;
            SupplyTypeName = supplyTypeName;
            SupplyTypeAmount = supplyTypeAmount;
        }
    }
}
