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
