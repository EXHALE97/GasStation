using System;
using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface IHistoryRepository : IDisposable
    {
        List<OperationHistory> GetHistory();
    }
}