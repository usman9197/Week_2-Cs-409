using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1) Add  2) Sub  3) Mul  4) Div  Q) Quit");
        Console.Write("Choose: ");
        string? choice = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(choice) ||
            choice.Equals("Q", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Goodbye.");
            return;
        }

        // Read operand A safely
        Console.Write("A: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Bad A (not a number).");
            return;
        }

        // Read operand B safely
        Console.Write("B: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Bad B (not a number).");
            return;
        }

        double result;

        switch (choice.Trim())
        {
            case "1":
                result = a + b;
                break;
            case "2":
                result = a - b;
                break;
            case "3":
                result = a * b;
                break;
            case "4":
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = a / b;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"Result = {result:F2}");
    }
}
