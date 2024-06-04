using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) :base(date, duration)
    {
        _distance = distance;
        _activityType = "Running";
    }


    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round((_distance/_duration)*60, 2);
    }
    public override double GetPace()
    {
        return Math.Round(60/GetSpeed(), 2);
    }

}