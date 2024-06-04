using System;

public class Biking : Activity
{
    private double _speed;

    public Biking(string date, int duration, double speed) :base(date, duration)
    {
        _speed = speed;
        _activityType = "Biking";
    }

    public override double GetDistance()
    {
        double distance = _duration*(_speed/60);
        return Math.Round(distance, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    public override double GetPace()
    {
        return Math.Round(60/GetSpeed(), 2);
    }
}