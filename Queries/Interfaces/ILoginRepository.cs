using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ILoginRepository
    {
        string LoginToTable(Login login);

        void AddNewDbUser(DBUser dbUser);

        string GetRolePass(string role);

        bool CheckLoginExistence(string login);

        void DeleteStaffFromLoginTable(string id);
    }
}
