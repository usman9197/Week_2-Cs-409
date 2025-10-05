using System;

class Program
{
    static void Main()
    {
        // Create an array to store 3 numbers
        double[] values = new double[3];

        // Loop to get 3 valid numbers from the user
        for (int i = 0; i < values.Length; i++)
        {
            while (true)
            {
                Console.Write($"Enter number #{i + 1}: ");
                string? input = Console.ReadLine();

                // Try to convert text into a number safely
                if (double.TryParse(input, out double number))
                {
                    values[i] = number; // store the valid number
                    break;              // exit while loop
                }
                else
                {
                    Console.WriteLine("Invalid number. Try again.");
                }
            }
        }

        // Calculate the sum of the numbers
        double sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        // Calculate the average
        double average = sum / values.Length;

        // Display the result with 2 decimal places
        Console.WriteLine($"Average = {average:F2}");
    }
}
