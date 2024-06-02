using System;

public class Reception : Event
{
    private string _RSVPemail;
    public Reception(string eventName, string description, string date, string time, Address address, string RSVPemail) : base(eventName, description, date, time, address)
    {
        _RSVPemail = RSVPemail;   
    }

    public void GetFullDetails()
    {
        base.GetStandardDetails();
        Console.WriteLine($"Please RSVP to {_RSVPemail}.");
    }
    public void GetShortDescription()
    {
        Console.WriteLine($"\nReception: {base._eventName} on {base._date}");
    }
}