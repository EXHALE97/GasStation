namespace Queries.Entities
{
    public class Credentials
    {
        public int Id { get; }
        public string Login { get; }
        public string Password { get; }
        public string Role { get; set; }

        public Credentials(string login, string password, string role)
        {
            Login = login;
            Password = password;
            Role = role;
        }

        public Credentials(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
