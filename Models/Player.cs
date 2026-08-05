namespace GamingTournamentSystem.Models
{
    public class Player
    {
        // Primary Key
        public int PlayerID { get; set; }

        // Foreign Key (Users Table)
        public int UserID { get; set; }

        // Foreign Key (Teams Table)
        public int TeamID { get; set; }

        // User Information
        public string FullName { get; set; } = "";
        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        // Player Information
        public string InGameName { get; set; } = "";
        public string Phone { get; set; } = "";
        public int Age { get; set; }
        public string Role { get; set; } = "";

        // Empty Constructor
        public Player()
        {

        }

        // ======================================================
        // Constructor for Add Player
        // ======================================================
        public Player(
            int teamID,
            string fullName,
            string username,
            string email,
            string password,
            string inGameName,
            string phone,
            int age,
            string role)
        {
            TeamID = teamID;
            FullName = fullName;
            Username = username;
            Email = email;
            Password = password;
            InGameName = inGameName;
            Phone = phone;
            Age = age;
            Role = role;
        }

        // ======================================================
        // Constructor for Update Player
        // ======================================================
        public Player(
            int playerID,
            int userID,
            int teamID,
            string fullName,
            string username,
            string email,
            string password,
            string inGameName,
            string phone,
            int age,
            string role)
        {
            PlayerID = playerID;
            UserID = userID;
            TeamID = teamID;
            FullName = fullName;
            Username = username;
            Email = email;
            Password = password;
            InGameName = inGameName;
            Phone = phone;
            Age = age;
            Role = role;
        }
    }
}