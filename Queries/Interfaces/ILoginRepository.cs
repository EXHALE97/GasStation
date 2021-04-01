using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queries.Entities;

namespace Queries.Interfaces
{
    public interface ILoginRepository
    {
        string LoginToTable(Login login);

        void AddNewDBUser(DBUser dbUser);

        string GetRolePass(string role);

        bool CheckLoginExistence(string cardnum);

        void DeleteStaffFromLoginTable(string id);

    }
}
