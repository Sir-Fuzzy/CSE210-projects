using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("7263 E 4590 W", "New Rogerton", "USA", 72108);
        Customer customer1 = new Customer("Joe Schmoe", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Shampoo, Ocean Mist", "298-940-1890", 2.99, 4);
        Product product2 = new Product("Beard Balm", "399-091-0093", 4.87, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);


        Address address2 = new Address("17 Drottningsgatan", "Borås", "Sweden", 15729);
        Customer customer2 = new Customer("Bengt Jansson", address2);

        Order order2 = new Order(customer2);

        Product product3 = new Product("Shampoo, Zen Garden", "888-788-3457", 2.99, 2);
        Product product4 = new Product("Deoderant, Sage Plains", "083-277-5421", 7.32, 4);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order1.GetShippingLabel();
        order1.GetPackingLabel();
        Console.WriteLine("$"+order1.GetTotal());

        order2.GetShippingLabel();
        order2.GetPackingLabel();
        Console.WriteLine("$"+order2.GetTotal());

    }
}