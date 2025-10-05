using System;

class Program
{
    static void Main()
    {
        int n;

        // Ask user how many marks they will enter
        while (true)
        {
            Console.Write("How many marks (N): ");
            string? s = Console.ReadLine();
            if (int.TryParse(s, out n) && n > 0)
                break;

            Console.WriteLine("Enter a positive whole number.");
        }

        int[] marks = new int[n];
        long sum = 0;
        int min = int.MaxValue, max = int.MinValue;

        // Read marks safely with validation
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write($"Mark #{i + 1} (0..100): ");
                string? s = Console.ReadLine();

                if (int.TryParse(s, out int m) && m >= 0 && m <= 100)
                {
                    marks[i] = m;
                    sum += m;

                    if (m < min) min = m;
                    if (m > max) max = m;
                    break;
                }

                Console.WriteLine("Invalid mark. Enter 0..100.");
            }
        }

        // Calculate average
        double avg = sum / (double)n;

        // Show summary
        Console.WriteLine();
        Console.WriteLine($"Min: {min}, Max: {max}, Avg: {avg:F2}");
        Console.WriteLine("Chart (each * = 1 point above Min):");

        // Draw chart
        for (int i = 0; i < n; i++)
        {
            int stars = marks[i] - min; // normalized relative to lowest mark
            if (stars < 0) stars = 0;

            Console.Write($"M{i + 1} ({marks[i]}): ");
            for (int k = 0; k < stars; k++)
                Console.Write('*');
            Console.WriteLine();
        }
    }
}
