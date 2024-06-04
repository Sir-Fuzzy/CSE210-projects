using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int duration, double laps) :base(date, duration)
    {
        _laps = laps;
        _activityType = "Swimming";
    }

    public override double GetDistance()
    {
        double distance = (_laps * 50)/1000;
        return Math.Round(distance, 2);
    }
    public override double GetSpeed()
    {
        double speed = (GetDistance()/_duration)*60;
        return Math.Round(speed, 2);
    }
    public override double GetPace()
    {
        
        return Math.Round(60/GetSpeed(), 2);
    }
    
}

