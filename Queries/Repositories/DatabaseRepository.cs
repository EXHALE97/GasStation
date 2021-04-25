using Queries.Connection;
using Queries.Interfaces;

namespace Queries.Repositories
{
    public class DatabaseRepository : BaseRepository, IDatabaseRepository
    {
        public DatabaseRepository(DataBaseConnection connection)
        {
            DataBaseConnection = connection;
        }

        public void Dispose()
        {
        }

        public void CreateBackup(string filepath)
        {
            ExecuteSqlNonQueryCommand($"BACKUP DATABASE gas_station TO DISK = '{filepath}'");
        }

        public void RestoreBackup(string filepath)
        {
            ExecuteSqlNonQueryCommand($"RESTORE DATABASE gas_station FROM DISK = '{filepath}' WITH RECOVERY");
        }
    }
}