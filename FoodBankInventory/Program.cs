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

            Console.WriteLine("=== COMMUNITY FOOD BANK INVENTORY SYSTEM ===");

            foreach (var it in items)
            {
                Console.WriteLine();
                Console.WriteLine($"ID: {it.Id}");
                Console.WriteLine($"Item: {it.Name}");
                Console.WriteLine($"Category: {it.Category}");
                Console.WriteLine($"Quantity: {it.Quantity}");
            }

            int totalUnits = items.Sum(it => it.Quantity);

            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine($"Total Inventory Units: {totalUnits}");
            Console.WriteLine("=====================================");
            
            int restockThreshold = 16;
            var lowStockItems = items.Where(it => it.Quantity < restockThreshold).ToList();

            Console.WriteLine();
            Console.WriteLine($"=== LOW STOCK REPORT (Below {restockThreshold} units) ===");

            if (lowStockItems.Count == 0)
            {
                Console.WriteLine("All items are adequately stocked.");
            }
            else
            {
                foreach (var item in lowStockItems)
                {
                    Console.WriteLine($"- {item.Name} ({item.Category}): {item.Quantity} remaining");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
    }

    internal record FoodItem(int Id, string Name, string Category, int Quantity);
}