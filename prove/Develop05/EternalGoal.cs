using System;


public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _totalPoints += _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalName} -- {_description}";
    }
}
