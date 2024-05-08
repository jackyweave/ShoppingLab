
class ShoppingListApp
{
    static void Main()
    {
        // Menu items and prices
        Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
        {
            { "Pizza", 10.99m },
            { "Chips", 5.49m },
            { "Wings", 8.75m },
            { "Milk", 3.99m },
            { "Dish soap", 12.50m },
            { "Cheese", 6.25m },
            { "Meat", 9.99m },
            { "Eggs", 7.99m }
        };

        List<string> shoppingList = new List<string>();

        bool shopping = true;
        while (shopping)
        {
            Console.WriteLine("Menu Items:");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }

            Console.Write("Enter an item name: ");
            string userInput = Console.ReadLine();

            if (menu.ContainsKey(userInput))
            {
                shoppingList.Add(userInput);
                Console.WriteLine($"Added {userInput} to your order.");
            }
            else
            {
                Console.WriteLine("Error: Item not found. Please try again.");
            }

            Console.Write("Do you want to add another item? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
            {
                shopping = false;
            }
        }

        Console.WriteLine("\nItems Ordered:");
        foreach (var item in shoppingList)
        {
            Console.WriteLine($"{item}: ${menu[item]}");
        }

        decimal total = 0;
        foreach (var item in shoppingList)
        {
            total += menu[item];
        }

        Console.WriteLine($"\n**Total Price**: ${total}");
    }
}


