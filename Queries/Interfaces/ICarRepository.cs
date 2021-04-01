using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries.Entities;
using Queries.Interfaces;

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
