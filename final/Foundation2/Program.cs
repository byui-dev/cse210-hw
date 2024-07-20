using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("19 Elm St", "Hometown", "CA", "USA");
        Address nonUsaAddress = new Address("456 Sunny Rd", "Hero City", "Ontario", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("Phillip Mathews", usaAddress);
        Customer nonUsaCustomer = new Customer("Rebecca Evans", nonUsaAddress);

        // Create products
        Product product1 = new Product("Paint brush", "CH001", 15.99m, 2);
        Product product2 = new Product("Marker", "TB001", 1.99m, 1);
        Product product3 = new Product("Raw Linseed Oil", "LP001", 39.99m, 3);

        // Create orders and add products
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        DisplayOrderInfo(order1);
        Console.WriteLine();
        DisplayOrderInfo(order2);
    }

    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}");
    }
}
