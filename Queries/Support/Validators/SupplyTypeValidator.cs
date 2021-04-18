using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class SupplyTypeValidator
    {
        public static bool CheckFields(SupplyType supplyType, out List<string> errorList)
        {
            errorList = new List<string>();
            if (supplyType.Id >= 0) return true;
            errorList.Add("Товар не обнаружен!");
            return false;
        }

        public static bool CheckDelete(int id, out List<string> errorList)
        {
            errorList = new List<string>();
            if (id >= 0) return true;
            errorList.Add("Товар не обнаружен!");
            return false;
        }
    }
}