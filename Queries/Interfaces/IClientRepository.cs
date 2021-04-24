using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IClientRepository : IDisposable
    {
        List<Client> GetClients();

        List<int> GetNonActivatedClientCards();

        List<int> GetActivatedClientCards();

        void AddToClientTable(Client client);

        string GetClientFullNameById(int id);

        int GetDiscountPercentForClient(int clientCardId);

        void SetClientCredentials(int clientId, Credentials credentials);

        int GetClientIdByCardId(int cardId);
    }
}
