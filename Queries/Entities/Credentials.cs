namespace Queries.Entities
{
    public class Credentials
    {
        private readonly string userId;
        private readonly string password;
        private readonly string role;

        public Credentials(string userId, string password, string role)
        {
            this.userId = userId;
            this.password = password;
            this.role = role;
        }

        public Credentials(string userId, string password)
        {
            this.userId = userId;
            this.password = password;
        }

        public string GetLogin() => userId;
        public string GetPassword() => password;
        public string GetRole() => role;
    }
}
