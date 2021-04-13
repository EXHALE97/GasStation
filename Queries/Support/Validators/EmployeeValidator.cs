using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class EmployeeValidator
    {
        public static bool CheckEmployee(Employee employee, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (employee.SurName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (employee.Name == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (employee.Birthday.Year > 2003 || employee.Birthday.Year < 1955)
            {
                checkFlag = false;
                errorList.Add("Возраст указан неверно!");
            }
            if (employee.EmploymentDate.Year < employee.Birthday.Year + 18)
            {
                checkFlag = false;
                errorList.Add("Дата найма указана неверно!");
            }
            if (employee.Position == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Должность не задана!");
            }
            if (employee.Address == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Адрес не задан!");
            }
            if (employee.Salary < 500)
            {
                checkFlag = false;
                errorList.Add("Зарплата не может быть меньше 500 рублей!");
            }
            if (employee.ContractEndDate.Year < employee.EmploymentDate.Year)
            {
                checkFlag = false;
                errorList.Add("Дата окончания контракта указана неверно!");
            }
            else if (employee.ContractEndDate.Year == employee.EmploymentDate.Year && 
                     employee.ContractEndDate.Month < employee.EmploymentDate.Month)
            {
                checkFlag = false;
                errorList.Add("Дата окончания контракта указана неверно!");
            }
            else if (employee.ContractEndDate.Year == employee.EmploymentDate.Year && 
                     employee.ContractEndDate.Month == employee.EmploymentDate.Month && 
                     employee.ContractEndDate.Day <= employee.EmploymentDate.Day)
            {
                checkFlag = false;
                errorList.Add("Дата окончания контракта указана неверно!");
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
