using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to OnlineOrdering.");
        Console.WriteLine("====================================");
    

        // Create addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "10001", "USA");
        Address nonUsaAddress = new Address("456 Oak Ave", "Toronto", "ON", "M5J 2T3", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", usaAddress);
        Customer customer2 = new Customer("Emma Johnson", nonUsaAddress);

        // Create products
        Product product1 = new Product("Laptop", "P100", 999.99, "High-performance laptop");
        Product product2 = new Product("Mouse", "P200", 25.50, "Wireless mouse");
        Product product3 = new Product("Keyboard", "P300", 49.99, "Mechanical keyboard");
        Product product4 = new Product("Monitor", "P400", 199.99, "24-inch HD monitor");

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 1);
        order1.AddProduct(product2, 2);
        order1.AddProduct(product3, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2, 1);
        order2.AddProduct(product3, 1);
        order2.AddProduct(product4, 1);

        // Display order details
        DisplayOrderDetails(order1);
        Console.WriteLine("-----------------------------------");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine("\n" + order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}");
    }
}

