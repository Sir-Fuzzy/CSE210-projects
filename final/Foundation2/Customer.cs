using System;


public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    
    
    public bool IsInUS()
    {
        if (_address.IsInUS() == true)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
}