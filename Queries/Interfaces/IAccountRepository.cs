using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IAccountRepository : IDisposable
    {
        List<Account> GetAccounting();

        List<Account> GetAccountingBYStationID(int id);

    }
}
