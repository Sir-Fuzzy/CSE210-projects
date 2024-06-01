using System;
using System.Numerics;


public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();


    public Order(Customer customer)
    {
        _customer = customer;
    }

    
    
    public int GetShipping()
    {
        if (_customer.IsInUS() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double GetSubtotal()
    {
        double subTotal = 0;
        foreach(Product product in _products)
        {
            subTotal += product.GetTotalProductCost();
        }
        return subTotal;
    }

    public double GetTotal()
    {
        double total = GetSubtotal() + GetShipping();
        return Math.Round(total, 2);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Contents:");
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetName()+$" - ({product.GetID()}) Qty. {product.GetQuantity()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"\n{_customer.GetName()} \n{_customer.GetAddress().GetAddressString()}");
    }

}