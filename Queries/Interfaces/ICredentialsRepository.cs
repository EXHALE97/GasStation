using System.Collections.Generic;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ICredentialsRepository
    {
        string GetRoleByCredentials(Credentials login);

        int AddNewCredentials(Credentials dbUser);

        string GetCredentialsLoginById(int id);

        int GetCredentialsIdCountByLogin(string login);

        int GetCredentialsIdByLogin(string login);

        IList<string> GetUserLogins();
    }
}
