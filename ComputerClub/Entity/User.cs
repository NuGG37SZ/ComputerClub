namespace ComputerClub.Entity
{
    public class User
    {
        public int Id { get; private set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }


        public User() { }
        public User(int id, string login, string password, string role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = role;
        }

        public User(string login, string password, string role) 
        {
            Login = login;
            Password = password;
            Role = role;
        }
    }
}
