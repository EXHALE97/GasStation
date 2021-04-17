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
            bool checkFlag = true;
            //if (deal.GetFuelType() == String.Empty)
            //{
            //    checkFlag = false;
            //    errorList.Add("Тип топлива не выбран!");
            //}
            //if (deal.GetFuelAmount() <= 0)
            //{
            //    checkFlag = false;
            //    errorList.Add("Количество топлива введено неверно!");
            //}
            //if (deal.GetDealPrice() <= 0)
            //{
            //    checkFlag = false;
            //    errorList.Add("Цена сделки задана неверно!");
            //}
            //if (deal.GetDealDate().DayOfYear != DateTime.Now.DayOfYear && deal.GetDealDate().Year != DateTime.Now.Year)
            //{
            //    checkFlag = false;
            //    errorList.Add("Дата задана неверно!");
            //}

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
                errorList.Add("Тип топлива не выбран!");
            }
            if (deal.SupplyTypeAmount <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива введено неверно!");
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
