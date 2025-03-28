using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1989 Cornelia St", "New York", "NY", "USA");
        Address address2 = new Address("2145 Pines St", "Posadas", "MNES", "Argentina");

        Customer customer1 = new Customer("Tay Swizzle", address1);
        Customer customer2 = new Customer("Pamela Wall", address2);

        Product product1 = new Product("Typewriter", "TY-VINTAGE-001", 150.00, 1);
        Product product2 = new Product("Scarf", "SC-WOOL-RED-002", 29.99, 1);
        Product product3 = new Product("Keyboard", "KB-HYPERX-ORIGIN", 49.99, 1);
        Product product4 = new Product("Monitor", "MT-DELL-27FHD", 199.99, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}