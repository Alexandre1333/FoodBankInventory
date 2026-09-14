using System;
using System.Collections.Generic;

namespace FoodBankInventory
{
    internal class Program
    {
        static void Main()
        {
            var items = new List<FoodItem>
            {
                new FoodItem(101, "Canned Beans", "Canned Food", 24),
                new FoodItem(102, "Rice", "Dry Food", 15),
                new FoodItem(103, "Peanut Butter", "Shelf-stable", 12),
                new FoodItem(104, "Pasta", "Dry Food", 18),
                new FoodItem(105, "Tomato Soup", "Canned Food", 30)
            };

            Console.WriteLine("=== COMMUNITY FOOD BANK INVENTORY ===");

            foreach (var it in items)
            {
                Console.WriteLine();
                Console.WriteLine($"ID: {it.Id}");
                Console.WriteLine($"Item: {it.Name}");
                Console.WriteLine($"Category: {it.Category}");
                Console.WriteLine($"Quantity: {it.Quantity}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    internal record FoodItem(int Id, string Name, string Category, int Quantity);
}
