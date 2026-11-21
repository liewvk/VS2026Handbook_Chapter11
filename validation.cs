
using System;

namespace VS2026Handbook_Ch11
{
    internal class validation
    {
        static void Main(string[] args)
        {
            foreach (string sample in new[] { "42", "abc", "17" })
            {
                if (int.TryParse(sample, out int value))
                {
                    Console.WriteLine($"Valid: {value}");
                }
                else
                {
                    Console.WriteLine("Invalid whole number");
                }
            }
        }
    }
}

