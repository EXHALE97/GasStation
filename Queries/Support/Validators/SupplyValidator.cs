using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public class SupplyValidator
    {

        public SupplyValidator()
        {

        }

        public bool CheckAddition(Supply sup, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (sup.GetStationID() < 0)
            {
                checkFlag = false;
            }
            if (sup.GetStaffID() < 0)
            {
                checkFlag = false;
            }
            if (sup.GetFuelSupplyType() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (sup.GetFuelSupplyAmount() <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива задано неправильно!");
            }

            return checkFlag;
        }
    }
}
