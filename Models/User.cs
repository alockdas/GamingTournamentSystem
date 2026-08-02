namespace GamingTournamentSystem.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string FullName { get; set; } = "";

        public string Username { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string Role { get; set; } = "";

        public User()
        {

        }

        public User(string fullName, string username, string email, string password, string role)
        {
            FullName = fullName;
            Username = username;
            Email = email;
            Password = password;
            Role = role;
        }

        public User(int userID, string fullName, string username, string email, string password, string role)
        {
            UserID = userID;
            FullName = fullName;
            Username = username;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}