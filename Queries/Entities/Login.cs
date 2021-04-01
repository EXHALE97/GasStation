using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Entities
{
    public class Login
    {
        public string l_Login { private set; get; }
        public string l_Password { private set; get; }
        public string l_Role { private set; get; }

        public void setLogin(string Login, string Password, string Role)
        {
            l_Login = Login;
            l_Password = Password;
            l_Role = Role;
        }

        public void setLogin(string Login, string Password)
        {
            l_Login = Login;
            l_Password = Password;
        }

        public string GetLogin() => l_Login;
        public string GetPassword() => l_Password;
        public string GetRole() => l_Role;
    }
}
