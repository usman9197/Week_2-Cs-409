using System;

class Program
{
    static void Main()
    {
        Console.Write("Full name: ");
        string? fullNameIn = Console.ReadLine();

        Console.Write("City: ");
        string? cityIn = Console.ReadLine();

        // Check if both fields were filled
        if (string.IsNullOrWhiteSpace(fullNameIn) || string.IsNullOrWhiteSpace(cityIn))
        {
            Console.WriteLine("Both name and city are required.");
            return;
        }

        string fullName = fullNameIn.Trim();
        string city = cityIn.Trim();

        // Split full name into words (remove extra spaces)
        string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Get initials: first letter of first and last word (if present)
        char firstInitial = char.ToUpperInvariant(parts[0][0]);
        char lastInitial = (parts.Length > 1)
            ? char.ToUpperInvariant(parts[^1][0]) // ^1 = last element
            : '_'; // use underscore if only one name given

        // Create initials string
        string initials = (lastInitial == '_')
            ? $"{firstInitial}."
            : $"{firstInitial}.{lastInitial}.";

        // Count total characters in full name (including spaces)
        int nameLength = fullName.Length;

        // Create an ID using city, initials, and name length
        string id = $"{city.ToUpperInvariant()}_{firstInitial}{(lastInitial == '_' ? "" : lastInitial.ToString())}_{nameLength}";

        // Output the formatted report
        Console.WriteLine();
        Console.WriteLine($"Hello, {fullName} ({initials}) from {city}");
        Console.WriteLine($"Name length: {nameLength}");
        Console.WriteLine($"ID: {id}");
    }
}
