
using System;

namespace VS2026Handbook_Ch11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string? text = Console.ReadLine();

            if (int.TryParse(text, out int age) && age >= 0)
            {
                Console.WriteLine($"Age next year: {age + 1}");
            }
            else
            {
                Console.WriteLine("Enter a valid nonnegative age.");
            }
        }
    }
}


