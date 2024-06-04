using System;

public abstract class Activity
{
    protected string _date;
    protected int _duration;
    protected string _activityType;


    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_duration} min)- Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min/km");
    }

}