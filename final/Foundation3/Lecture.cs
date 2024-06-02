using System;

public class Lecture : Event
{
    private int _capacity;

    public Lecture(string eventName, string description, string date, string time, Address address, int capacity) : base(eventName, description, date, time, address)
    {
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"Act now! There are only {_capacity} total seats availible.");
    }
    public void GetShortDescription()
    {
        Console.WriteLine($"\nLecture: {base._eventName} on {base._date}");
    }

}