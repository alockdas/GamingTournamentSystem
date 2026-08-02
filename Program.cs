using GamingTournamentSystem.Models;
using GamingTournamentSystem.Services;

AuthenticationService auth = new AuthenticationService();

// Register Test
// User user = new User("Alock", "1234", "Admin");
// auth.Register(user);

// Login Test
User? loggedUser = auth.Login("Alock", "1234");

if (loggedUser != null)
{
    Console.WriteLine("Login Successful!");
    Console.WriteLine($"Welcome {loggedUser.Username}");
    Console.WriteLine($"Role: {loggedUser.Role}");
}
else
{
    Console.WriteLine("Invalid Username or Password!");
}