using System;

public class Address
{

    private string _streetAddress;
    private string _city;
    private string _country;
    private int _zipCode;


    public Address (string streetAddress, string city, string country, int zip)
    {
        _streetAddress = streetAddress;
        _city = city;
        _country = country;
        _zipCode = zip;
    }


    public bool IsInUS()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAddressString()
    {
        return $"{_streetAddress}, {_city}, {_country} {_zipCode}";
    }
}