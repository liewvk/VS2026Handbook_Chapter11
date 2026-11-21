
using System;

namespace VS2026Handbook_Ch11
{
    internal class invoice
    {
        static void Main(string[] args)
        {
            double price = 36.50;
            int quantity = 4;

            double subtotal = price * quantity;
            double tax = Math.Round(subtotal * 0.06, 2);

            Console.WriteLine($"Subtotal: RM{subtotal:F2}");
            Console.WriteLine($"Tax: RM{tax:F2}");
            Console.WriteLine($"Total: RM{subtotal + tax:F2}");
        }
    }
}

