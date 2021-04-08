using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class CredentialsValidator
    {
        public static bool CheckAddition(Credentials user, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            string login = user.login, password = user.password, role = user.role;
            if (login == string.Empty || login.Length < 4 && !role.Equals("worker"))
            {
                checkFlag = false;
                errorList.Add("Логин должн быть не меньше 4 символов!");
            }
            if (password == string.Empty || password.Length < 6)
            {
                checkFlag = false;
                errorList.Add("Пароль должн быть не меньше 6 символов!");
            }
            if (role == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Роль указана неверно!");
            }

            return checkFlag;
        }
    }
}
