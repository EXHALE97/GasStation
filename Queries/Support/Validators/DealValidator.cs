using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class DealValidator
    {

        public static bool CheckAddition(Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (deal.Station == null)
            {
                checkFlag = false;
                errorList.Add("Тип товара не выбран!");
            }
            if (deal.SupplyType == null)
            {
                checkFlag = false;
                errorList.Add("Тип товара не выбран!");
            }
            if (deal.SupplyTypeAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество товара введено неверно!");
            }
            if (deal.Price <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }
            if (deal.Date.DayOfYear != DateTime.Now.DayOfYear && deal.Date.Year != DateTime.Now.Year)
            {
                checkFlag = false;
                errorList.Add("Дата задана неверно!");
            }

            return checkFlag;
        }

        public static bool CheckUpdate(Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (deal.ClientCardId <= 0)
            {
                checkFlag = false;
                errorList.Add("Покупатель не обнаружен!");
            }
            if (deal.SupplyType == null)
            {
                checkFlag = false;
                errorList.Add("Тип товара не выбран!");
            }
            if (deal.SupplyTypeAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество товара введено неверно!");
            }
            if (deal.Price <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }
            
            return checkFlag;
        }
    }
}
