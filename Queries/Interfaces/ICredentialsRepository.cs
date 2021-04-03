using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ICredentialsRepository
    {
        string LoginToTable(Credentials login);

        void AddNewDbUser(Credentials dbUser);

        string GetRolePass(string role);

        bool IsThereCurrentCredentialsInTable(string login);

        void DeleteStaffFromLoginTable(string id);
    }
}
