using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Queries.Connection;
using Queries.Entities;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class HistoryRepository : BaseRepository, IHistoryRepository
    {
        public HistoryRepository(DataBaseConnection dbc)
        {
            DataBaseConnection = dbc;
        }

        public void Dispose()
        {
        }

        public List<OperationHistory> GetHistory()
        {
            return ExecuteSqlCommand("EXEC HistorySummary", queryResult =>
            {
                var list = new List<OperationHistory>();
                if (queryResult.HasRows)
                {
                    list.AddRange(from DbDataRecord dbDataRecord in queryResult
                        select new OperationHistory(int.Parse(dbDataRecord["id"].ToString()),
                            dbDataRecord["operation"].ToString(),
                            Convert.ToDateTime(dbDataRecord["create_at"].ToString())));
                }

                queryResult.Close();
                return list;
            });
        }
    }
}