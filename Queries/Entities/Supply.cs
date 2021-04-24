using System;

namespace Queries.Entities
{
    public class Supply
    {
        public int StationId { get; }
        public string StationName { get; }
        public int EmployeeId { get; }
        public string EmployeeName { get; }
        public int SupplyTypeId { get; }
        public string SupplyTypeName { get; }
        public double SupplyTypeAmount { get; }
        public DateTime SupplyDate { get; }

        public Supply(int stationId, string stationName, int employeeId, string employeeName, int supplyTypeId, string supplyTypeName,
            double supplyTypeAmount, DateTime supplyDate)
        {
            StationId = stationId;
            StationName = stationName;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            SupplyTypeId = supplyTypeId;
            SupplyTypeName = supplyTypeName;
            SupplyTypeAmount = supplyTypeAmount;
            SupplyDate = supplyDate;
        }

        public Supply(int stationId, int employeeId, int supplyTypeId, double supplyTypeAmount, DateTime supplyDate)
        {
            StationId = stationId;
            EmployeeId = employeeId;
            SupplyTypeId = supplyTypeId;
            SupplyTypeAmount = supplyTypeAmount;
            SupplyDate = supplyDate;
        }
    }
}
