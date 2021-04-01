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
    public class CarValidator
    {
        public CarValidator()
        {

        }

        public bool CheckAddition(Car car, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (car.GetCarMark() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Марка и модель автомобиля не задана!");
            }
            if (car.GetCardNum() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Номер карты не задан!");
            }

            return checkFlag;
        }
    }
}
