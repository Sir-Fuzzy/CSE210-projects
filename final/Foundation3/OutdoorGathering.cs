using System;

public class OutdoorGathering : Event
{

    private string _weatherForecast;
    public OutdoorGathering(string eventName, string description, string date, string time, Address address, string weatherForecast) : base(eventName, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"{_weatherForecast} is expected on that day.");
    }

    public void GetShortDescription()
    {
        Console.WriteLine($"\nOutdoor Gathering: {base._eventName} on {base._date}");
    }
    
}