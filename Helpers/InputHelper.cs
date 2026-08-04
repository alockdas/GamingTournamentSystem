// ======================================================
// File: InputHelper.cs
// Purpose:
// Provides reusable methods for taking validated user input.
// ======================================================
using System.Text.RegularExpressions;
namespace GamingTournamentSystem.Helpers
{
    public static class InputHelper
    {
        // ======================================================
        // Read an integer value
        // ======================================================
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }

                Console.WriteLine("❌ Invalid number! Please try again.\n");
            }
        }

        // ======================================================
        // Read a decimal value
        // ======================================================
        public static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                {
                    return value;
                }

                Console.WriteLine("❌ Invalid amount! Please try again.\n");
            }
        }

        // ======================================================
        // Read a date
        // ======================================================
        public static DateTime ReadDate(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    return date;
                }

                Console.WriteLine("❌ Invalid date! Use yyyy-mm-dd.\n");
            }
        }

        // ======================================================
        // Read a non-empty string
        // ======================================================
        public static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);

                string? value = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(value))
                {
                    return value.Trim();
                }

                Console.WriteLine("❌ This field cannot be empty.\n");
            }
        }

        // ======================================================
        // Read tournament status
        // ======================================================
        public static string ReadStatus()
        {
            while (true)
            {
                Console.Write("Status (Upcoming/Running/Completed): ");

                string? status = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(status))
                {
                    Console.WriteLine("❌ Status cannot be empty.\n");
                    continue;
                }

                status = status.Trim();

                if (status.Equals("Upcoming", StringComparison.OrdinalIgnoreCase))
                    return "Upcoming";

                if (status.Equals("Running", StringComparison.OrdinalIgnoreCase))
                    return "Running";

                if (status.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                    return "Completed";

                Console.WriteLine("❌ Invalid status! Allowed values:");
                Console.WriteLine("   • Upcoming");
                Console.WriteLine("   • Running");
                Console.WriteLine("   • Completed\n");
            }
        }

        public static string ReadRole()
        {
            while (true)
            {
                Console.Write("Role (Admin/Organizer/Player): ");
                string? role = Console.ReadLine()?.Trim();
        
                if (!string.IsNullOrWhiteSpace(role))
                {
                    role = role.ToLower();
        
                    if (role == "admin" || role == "organizer" || role == "player")
                    {
                        return char.ToUpper(role[0]) + role.Substring(1);
                    }
                }
        
                Console.WriteLine("❌ Invalid role. Enter Admin, Organizer or Player.");
                Console.WriteLine();
            }
        }

        // ======================================================
        // Read a valid email address
        // ======================================================
        public static string ReadEmail(string message)
        {
            while (true)
            {
                Console.Write(message);

                string? email = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("❌ Email cannot be empty.\n");
                    continue;
                }

                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (Regex.IsMatch(email, pattern))
                {
                    return email;
                }

                Console.WriteLine("❌ Invalid email format.\n");
            }
        }

        // ======================================================
        // Read a time
        // ======================================================
        public static TimeSpan ReadTime(string message)
        {
            while (true)
            {
                Console.Write(message);
        
                if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan time))
                {
                    return time;
                }
        
                Console.WriteLine("❌ Invalid time! Use HH:mm format.\n");
            }
        }
    }
}