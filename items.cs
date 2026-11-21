
using System;
using System.Linq;

namespace VS2026Handbook_Ch11
{
    internal class items
    {
        static void Main(string[] args)
        {
            var items = new (string Name, decimal Price)[]
            {
                ("Rice", 35.0m),
                ("Milk", 8.5m),
                ("Tea", 15.0m)
            };

            foreach (var item in items)
            {
                Console.WriteLine(
                    $"{item.Name,-20} RM{item.Price,8:F2}");
            }

            Console.WriteLine(
                $"Subtotal: RM{items.Sum(x => x.Price):F2}");

            Console.WriteLine(
                $"Largest cost: {items.MaxBy(x => x.Price)!.Name}");
        }
    }
}

