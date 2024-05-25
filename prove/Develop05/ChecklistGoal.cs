using System;


public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        _totalPoints += _points;
        _amountCompleted +=1;
        if (_amountCompleted ==_target)
        {
            _totalPoints += _bonus;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }


    public override string GetStringRepresentation()
    {
        if (IsComplete())
        {
            return $"[x] {_goalName} -- {_description} ({_amountCompleted}/{_target})";
        }
        else 
        {
            return $"[ ] {_goalName} -- {_description} ({_amountCompleted}/{_target})";
        }
    }
}