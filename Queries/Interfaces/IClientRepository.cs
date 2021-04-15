using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IClientRepository : IDisposable
    {
        List<Client> GetClients();

        List<string> GetCardNumList();

        void AddToCarTable(Client car);

        int FindCarIDByCardnum(string cardnum);

        string FindCardNumByCarID(int id);

    }
}
