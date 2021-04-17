using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IClientRepository : IDisposable
    {
        List<Client> GetClients();

        List<int> GetNonActivatedClientCards();

        List<string> GetCardNumList();

        void AddToClientTable(Client client);

        int FindCarIDByCardnum(string cardnum);

        string FindCardNumByCarID(int id);

    }
}
