using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Support.Validators
{
    public static class ClientValidator
    {
        public static bool CheckAddition(Client client, out List<string> errorList)
        {
            errorList = new List<string>();
            if (client.CardId != 0) return true;
            errorList.Add("Карта клиента не выбрана");
            return false;
        }
    }
}
