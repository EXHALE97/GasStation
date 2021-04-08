using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class EmployeeValidator
    {
        public static bool CheckAddition(Employee wk, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (wk.Id <= 0)
            {
                checkFlag = false;
                errorList.Add("Станция не выбрана!");
            }
            if (wk.SurName == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (wk.Name == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (wk.Birthday.Year > 2000 || wk.Birthday.Year < 1955)
            {
                checkFlag = false;
                errorList.Add("Возраст указан неверно!");
            }
            if (wk.Position == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Должность не задана!");
            }
            if (wk.Salary < 500)
            {
                checkFlag = false;
                errorList.Add("Зарплата не может быть дробным числом или быть меньше 500 у.е!");
            }

            return checkFlag;
        }

        public static bool CheckUpdate(int id, Employee wk, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (wk.SurName == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (wk.Name == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (wk.Position == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Должность не задана!");
            }
            if (wk.Salary < 500)
            {
                checkFlag = false;
                errorList.Add("Зарплата не может быть меньше 500 у.е!");
            }
            if (id < 0)
            { checkFlag = false; }

            return checkFlag;
        }

        public static bool CheckDelete(int id, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (id < 0)
            {
                checkFlag = false;
                errorList.Add("Сотрудник не обнаружен!");
            }

            return checkFlag;
        }
    }
}
