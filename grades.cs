
using System;

namespace VS2026Handbook_Ch11
{
    internal class grades
    {
        static void Main(string[] args)
        {
            int[] marks = { 42, 58, 73, 89, 96 };

            foreach (int mark in marks)
            {
                string grade = mark >= 80 ? "A" :
                               mark >= 65 ? "B" :
                               mark >= 50 ? "C" : "F";

                Console.WriteLine($"{mark}: {grade}");
            }
        }
    }
}
