using System;

namespace VS2026Handbook_Ch11
{
    internal class tax
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your annual income: RM ");

            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal income)
                && income >= 0)
            {
                // Example: Flat tax rate of 10%
                decimal taxAmount = income * 0.10m;

                Console.WriteLine($"Annual Income: RM {income:N2}");
                Console.WriteLine($"Tax Amount (10%): RM {taxAmount:N2}");
                Console.WriteLine($"Net Income: RM {income - taxAmount:N2}");
            }
            else
            {
                Console.WriteLine("Enter a valid nonnegative income.");
            }
        }
    }
}
