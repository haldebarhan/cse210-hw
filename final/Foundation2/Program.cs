using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new("101 E Viking St", "Rexburg", "Idaho", "USA");
        Customer customer = new("John Snow", address);
        Order order = new(customer);

        order.AddProduct(new Product("12129333", "Razer BlackShark", 39.99, 4));
        order.AddProduct(new Product("12129679", "BENGOO G9000 Stereo", 20.61, 2));
        order.AddProduct(new Product("12129087", "SAMSUNG Galaxy S24+", 999.99, 1));

        Console.Clear();
        Console.WriteLine($"{order.GetPackingLabel()}");

        Console.WriteLine($"{order.GetShippingLabel()}");
        Console.WriteLine($"\nTotal Cost: {order.TotalCoast().ToString().Replace(",", ".")}$");
    }
}