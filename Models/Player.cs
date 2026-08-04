namespace GamingTournamentSystem.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public string FullName { get; set; }
        public string InGameName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        // Constructor for Add
        public Player(
            int teamID,
            string fullName,
            string inGameName,
            string email,
            string phone,
            int age,
            string role)
        {
            TeamID = teamID;
            FullName = fullName;
            InGameName = inGameName;
            Email = email;
            Phone = phone;
            Age = age;
            Role = role;
        }

        // Constructor for Update
        public Player(
            int playerID,
            int teamID,
            string fullName,
            string inGameName,
            string email,
            string phone,
            int age,
            string role)
        {
            PlayerID = playerID;
            TeamID = teamID;
            FullName = fullName;
            InGameName = inGameName;
            Email = email;
            Phone = phone;
            Age = age;
            Role = role;
        }
    }
}   