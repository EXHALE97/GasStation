using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ICarRepository : IDisposable
    {
        List<Client> GetCars();

        List<string> GetCardNumList();

        void AddToCarTable(Client car);

        int FindCarIDByCardnum(string cardnum);

        string FindCardNumByCarID(int id);

    }
}
