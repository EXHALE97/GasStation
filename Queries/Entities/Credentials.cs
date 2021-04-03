namespace Queries.Entities
{
    public class Credentials
    {
        public string login { get; }
        public string password { get; }
        public string role { get; }

        public Credentials(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public Credentials(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
