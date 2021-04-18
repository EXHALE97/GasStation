using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class SupplyValidator
    {
        public static bool CheckAddition(Supply supply, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = !(supply.StationId <= 0);
            if (supply.EmployeeId <= 0)
            {
                checkFlag = false;
            }
            if (supply.SupplyTypeName == null)
            {
                checkFlag = false;
                errorList.Add("Тип товара не выбран!");
            }
            if (supply.SupplyTypeAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество товара задано неправильно!");
            }

            return checkFlag;
        }
    }
}
