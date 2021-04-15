using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class ClientValidator
    {
        public static bool CheckAddition(Client client, out List<string> errorList)
        {
            errorList = new List<string>();
            var checkFlag = true;
            if (client.LastName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Фамилия не задана!");
            }
            if (client.FirstName == string.Empty)
            {
                checkFlag = false;
                errorList.Add("Имя не задано!");
            }
            if (client.CardId == 0)
            {
                checkFlag = false;
                errorList.Add("Карта клиента не может быть с ID 0");
            }

            return checkFlag;
        }
    }
}
