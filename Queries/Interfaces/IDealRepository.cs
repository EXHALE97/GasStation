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
    public interface IDealRepository : IDisposable
    {
        List<Deal> ShowDealTable();

        List<Deal> ShowUserDealTable(int id);

        List<Deal> ShowWorkerDealTable(int id);

        List<Deal> GetDeals(Car car);

        void UpdateDealTable(int id, Deal deal);

        List<Deal> ShowBuyerDealTable(int id);

        void AddToDealTable(Deal deal);

    }
}
