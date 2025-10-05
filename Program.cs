using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No text entered.");
        }
        else
        {
            string trimmed = input.Trim();
            Console.WriteLine($"Trimmed     : {trimmed}");
            Console.WriteLine($"UPPER       : {trimmed.ToUpperInvariant()}");
            Console.WriteLine($"lower       : {trimmed.ToLowerInvariant()}");
            Console.WriteLine($"Length (raw): {input.Length}");     // includes outer whitespace
            Console.WriteLine($"Length (trim): {trimmed.Length}");  // outer whitespace removed
        }
    }
}
