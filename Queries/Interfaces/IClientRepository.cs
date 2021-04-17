using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IClientRepository : IDisposable
    {
        List<Client> GetClients();

        List<int> GetNonActivatedClientCards();

        void AddToClientTable(Client client);

        string FindClientById(int id);

        void SetClientCredentials(int clientId, Credentials credentials);

        int FindCarIDByCardnum(string cardnum);

    }
}
