using GamingTournamentSystem.Menus;
using GamingTournamentSystem.Helpers;
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
    
        string fullName = InputHelper.ReadString("Full Name: ");
    
        string username = InputHelper.ReadString("Username: ");
    
        if (auth.UsernameExists(username))
        {
            Console.WriteLine();
            Console.WriteLine("❌ Username already exists.");
            Pause();
            return;
        }
    
        string email = InputHelper.ReadEmail("Email: ");
    
        if (auth.EmailExists(email))
        {
            Console.WriteLine();
            Console.WriteLine("❌ Email already exists.");
            Pause();
            return;
        }
    
        string password = InputHelper.ReadString("Password: ");
    
        string role = InputHelper.ReadRole();
    
        User user = new User(fullName, username, email, password, role);
    
        auth.Register(user);
    
        Console.WriteLine();
        Console.WriteLine("✅ Registration Successful!");
    
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
            Console.WriteLine($"Welcome {user.FullName}");
            Console.WriteLine($"Role : {user.Role}");
        
            Pause();
        
            // Open Admin Dashboard after successful admin login
            if (user.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dashboard for this role is under development.");
                Pause();
            }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Username or Password!");
                Pause();
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