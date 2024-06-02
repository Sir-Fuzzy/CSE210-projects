using System;

public class Address
{

    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipCode;


    public Address (string streetAddress, string city, string state, int zip)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zip;
    }

    public string GetAddressString()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
}