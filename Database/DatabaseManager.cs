using MySql.Data.MySqlClient;

namespace GamingTournamentSystem.Database
{
    public class DatabaseManager
    {
        private readonly string connectionString =
            "Server=127.0.0.1;Port=3306;Database=GamingTournament;Uid=root;Pwd=admin123;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    Console.WriteLine("MySQL Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Failed!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}