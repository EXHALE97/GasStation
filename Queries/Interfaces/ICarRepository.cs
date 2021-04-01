using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ICarRepository : IDisposable
    {
        List<Car> GetCars();

        List<string> GetCardNumList();

        void AddToCarTable(Car car);

        int FindCarIDByCardnum(string cardnum);

        string FindCardNumByCarID(int id);

    }
}
