namespace Queries.Entities
{
    public class DBUser
    {
        public string DBUserLogin { private set; get; }
        public string DBUserPass { private set; get; }
        public string DBUserRole { private set; get; }

        public void setNewUser(string Login, string Pass, string Role)
        {
            DBUserLogin = Login;
            DBUserPass = Pass;
            DBUserRole = Role;
        }

        public string GetDBUserLogin() => DBUserLogin;
        public string GetDBUserPass() => DBUserPass;
        public string GetDBUserRole() => DBUserRole;
    }
}
