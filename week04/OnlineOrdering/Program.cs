using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System\n");

        // Order 1 - USA Customer
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Gift Scotch", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Headphones", "WH-456", 89.99m, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC-789", 12.50m, 2));
        order1.AddProduct(new Product("Laptop Sleeve", "LS-321", 24.99m, 1));

        // Order 2 - International Customer
        Address address2 = new Address("456 Ocean Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jordan Kundai", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-112", 129.99m, 1));
        order2.AddProduct(new Product("Gaming", "GM-334", 45.00m, 1));

        // Display results for Order 1
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\n" + order1.GetPackingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalPrice():F2}\n");

        // Display results for Order 2
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\n" + order2.GetPackingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalPrice():F2}\n");

        Console.WriteLine("Program complete. Press any key to exit...");
        Console.ReadKey();
    }
}