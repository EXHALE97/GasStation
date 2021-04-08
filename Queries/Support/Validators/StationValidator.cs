using System.Collections.Generic;
using System.Text.RegularExpressions;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class StationValidator
    {
        public static bool CheckAddition(Station station, out List<string> errorList)
        {
            var checkFlag = true;
            errorList = new List<string>();

            if (station.Name == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Название организации не задано!");
            }
            if (station.City == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Город не задан!");
            }
            if (station.Address == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Адрес не задан!");
            }
            else if (!new Regex("^[А-ЯA-Z]{1}[а-яa-z]+ ?([А-ЯA-Z]{1}[а-яa-z]+ )?[0-9]+$").Match(station.Address).Success)
            {
                checkFlag = false;
                errorList.Add("Улица задана неверно!");
            }

            return checkFlag;
        }

        public static string CheckRightStreet(string street)
        {
            for (var i = 1; i < street.Length; i++)
            {
                if ((street[i] >= '0' && street[i] <= '9') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= 'А' && street[i] <= 'Я') && (street[i - 1] >= 'а' && street[i - 1] <= 'я'))
                {
                    street = street.Insert(i, " ");
                }
                if ((street[i] >= 'A' && street[i] <= 'Z') && (street[i - 1] >= 'a' && street[i - 1] <= 'z'))
                {
                    street = street.Insert(i, " ");
                }
            }
            return street;
        }
    }
}
