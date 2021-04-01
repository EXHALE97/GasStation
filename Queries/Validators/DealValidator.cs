using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Repositories;
using Queries.Interfaces;

namespace Queries.Validators
{
    public class DealValidator
    {
        public DealValidator()
        {

        }

        public bool CheckAddition(Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (deal.GetFuelType() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (deal.GetFuelAmount() <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива введено неверно!");
            }
            if (deal.GetDealPrice() <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }
            //if (deal.GetDealDate().DayOfYear != DateTime.Now.DayOfYear && deal.GetDealDate().Year != DateTime.Now.Year)
            //{
            //    checkFlag = false;
            //    errorList.Add("Дата задана неверно!");
            //}

            return checkFlag;
        }

        public bool CheckUpdate(int id, Deal deal, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (deal.GetCarID() < 0)
            {
                checkFlag = false;
                errorList.Add("Покупатель не обнаружен!");
            }
            if (deal.GetFuelType() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Тип топлива не выбран!");
            }
            if (deal.GetFuelAmount() <= 0)
            {
                checkFlag = false;
                errorList.Add("Количество топлива введено неверно!");
            }
            if (deal.GetDealPrice() <= 0)
            {
                checkFlag = false;
                errorList.Add("Цена сделки задана неверно!");
            }

            return checkFlag;
        }
    }
}
