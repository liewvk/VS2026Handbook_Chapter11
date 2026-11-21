
using System;

namespace VS2026Handbook_Ch11
{
    internal class total
    {
        static void Main(string[] args)
        {
            decimal price = 12.50m;
            int quantity = 3;

            Console.WriteLine(
                $"Total: RM{price * quantity:F2}");
        }
    }
}

