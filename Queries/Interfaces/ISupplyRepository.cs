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
    public interface ISupplyRepository : IDisposable
    {
        List<Supply> ShowSupplyTable();

        void AddToSupplyTable(Supply sup);

        List<Supply> ShowSupplyTableByID(int ID);

        List<Supply> GetSupplyBYStationID(int id);

    }
}
