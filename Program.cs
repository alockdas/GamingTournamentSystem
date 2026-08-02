using GamingTournamentSystem.Database;
using GamingTournamentSystem.Menus;

DatabaseManager database = new DatabaseManager();

database.InitializeDatabase();

Console.WriteLine("Database Initialized Successfully!");

MainMenu menu = new MainMenu();
menu.Show();