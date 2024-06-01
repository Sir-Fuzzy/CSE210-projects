using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;


    public Product(string name, string ID, double price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }


    public double GetTotalProductCost()
    {
        return (_price*_quantity);
    }
    public string GetName()
    {
        return _name;
    }
    public string GetID()
    {
        return _productID;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}