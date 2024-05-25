using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected int _totalPoints;

    protected Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public int GetTotalPoints()
    {
        
        return _totalPoints;
    }

    public abstract string GetStringRepresentation();
    
}