
using System;

namespace VS2026Handbook_Ch11
{
    internal class score
    {
        static void Main(string[] args)
        {
            int score = 83;

            string grade = score >= 80 ? "A" :
                           score >= 60 ? "B" : "C";

            Console.WriteLine($"Grade: {grade}");
        }
    }
}

