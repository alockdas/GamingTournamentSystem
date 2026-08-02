using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

namespace GamingTournamentSystem.Menus;

public class MainMenu
{
    private AuthenticationService auth = new AuthenticationService();

    public void Show()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("==================================");
            Console.WriteLine("   GAMING TOURNAMENT SYSTEM");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose Option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Register();
                    break;

                case "2":
                    Login();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    Pause();
                    break;
            }
        }
    }

    private void Register()
    {
        Console.Clear();
    
        Console.WriteLine("===== REGISTER =====");
    
        Console.Write("Full Name: ");
        string fullName = Console.ReadLine()!;
    
        Console.Write("Username: ");
        string username = Console.ReadLine()!;
    
        Console.Write("Email: ");
        string email = Console.ReadLine()!;
    
        Console.Write("Password: ");
        string password = Console.ReadLine()!;
    
        Console.Write("Role (Admin/Organizer/Player): ");
        string role = Console.ReadLine()!;
    
        User user = new User(fullName, username, email, password, role);
    
        auth.Register(user);
    
        Console.WriteLine();
        Console.WriteLine("Registration Complete!");
    
        Pause();
    }

    private void Login()
    {
        Console.Clear();

        Console.WriteLine("===== LOGIN =====");

        Console.Write("Username: ");
        string username = Console.ReadLine()!;

        Console.Write("Password: ");
        string password = Console.ReadLine()!;

        User? user = auth.Login(username, password);

        if (user != null)
        {
            Console.WriteLine();
            Console.WriteLine($"Welcome {user.Username}");
            Console.WriteLine($"Role : {user.Role}");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid Username or Password!");
        }

        Pause();
    }

    private void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
    }
}