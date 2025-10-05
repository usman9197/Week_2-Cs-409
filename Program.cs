using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=== Calculator+ ===");
            Console.WriteLine("1) Add  2) Sub  3) Mul  4) Div  Q) Quit");
            Console.Write("Choose: ");
            string? pick = Console.ReadLine();

            // Exit the loop if user types Q or leaves it blank
            if (string.IsNullOrWhiteSpace(pick) ||
                pick.Equals("Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye.");
                break;
            }

            // Get first number safely
            Console.Write("A: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Bad A (not a number).");
                continue; // go back to menu
            }

            // Get second number safely
            Console.Write("B: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Bad B (not a number).");
                continue; // go back to menu
            }

            double result;

            // Perform the selected operation
            switch (pick.Trim())
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
                        continue; // go back to menu
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }

            // Display result formatted to 2 decimal places
            Console.WriteLine($"Result = {result:F2}");
        }
    }
}
