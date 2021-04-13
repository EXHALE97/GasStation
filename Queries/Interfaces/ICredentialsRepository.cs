using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ICredentialsRepository
    {
        string LoginToTable(Credentials login);

        void AddNewDbUser(Credentials dbUser);

        string GetCredentialsLoginById(int id);

        bool IsThereCurrentCredentialsInTable(string login);

        int GetCredentialsIdByLogin(string login);

        IList<string> GetUserLogins();
    }
}
