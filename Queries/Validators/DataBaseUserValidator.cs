using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Validators
{
    public class DataBaseUserValidator
    {
        public DataBaseUserValidator()
        {

        }

        public bool CheckAddition(DBUser user, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (user.GetDBUserLogin() == String.Empty || user.GetDBUserLogin().Length < 4 && !user.GetDBUserRole().Equals("worker"))
            {
                checkFlag = false;
                errorList.Add("Логин должн быть не меньше 4 символов!");
            }
            if (user.GetDBUserPass() == String.Empty || user.GetDBUserPass().Length < 6)
            {
                checkFlag = false;
                errorList.Add("Пароль должн быть не меньше 6 символов!");
            }
            if (user.GetDBUserRole() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Роль указана неверно!");
            }

            return checkFlag;
        }
    }
}
