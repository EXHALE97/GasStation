using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IAccountRepository
    {
        List<Accounting> GetAccounting();

        List<Accounting> GetAccountingBYStationID(int id);

    }
}
