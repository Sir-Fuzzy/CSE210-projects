using System;

public class SimpleGoal : Goal
{
    public bool _isComplete {get; set;}


    public SimpleGoal(string name, string description, int points):  base(name, description, points)
    {

    }


    public override void RecordEvent()
    {
        _isComplete = true;
        _totalPoints += _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        if (_isComplete)
        {
            return $"[x] {_goalName} -- {_description}";
        }
        else
        {
            return $"[ ] {_goalName} -- {_description} ({_points} pts)";
        }
    }

}