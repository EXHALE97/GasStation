﻿using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public class CarValidator
    {
        public CarValidator()
        {

        }

        public bool CheckAddition(Client car, out List<string> errorList)
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