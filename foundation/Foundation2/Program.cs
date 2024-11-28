using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P12345", 1200.00, 1);
        Product product2 = new Product("Mouse", "P12346", 25.50, 2);
        Product product3 = new Product("Keyboard", "P12347", 45.00, 1);

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 1: ${order1.CalculateTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price for Order 2: ${order2.CalculateTotalPrice()}\n");
    }
}