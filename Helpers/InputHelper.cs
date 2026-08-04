// ======================================================
// File: InputHelper.cs
// Purpose:
// Provides reusable methods for taking validated user input.
// ======================================================

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
    }
}