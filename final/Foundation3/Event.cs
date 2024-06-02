using System;

public class Event
{
    protected string _eventName;
    private string _description;
    protected string _date;
    private string _time;
    Address _address;


    public Event(string eventName, string description, string date, string time, Address address)
    {
        _eventName = eventName;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public void GetStandardDetails()
    {
        Console.WriteLine($"\n{_eventName}: \n{_description} on {_date} at {_time} \n{_address.GetAddressString()}");
    }
}