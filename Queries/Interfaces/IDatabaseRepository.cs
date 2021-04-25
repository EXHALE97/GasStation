using System;

namespace Queries.Interfaces
{
    public interface IDatabaseRepository : IDisposable
    {
        void CreateBackup(string filepath);

        void RestoreBackup(string filepath);
    }
}