using System;

public abstract class Goal
{
    public string _goalName {get; set;}
    public string _description {get; set;}
    public int _points {get; set;}
    public int _totalPoints {get; set;}


    public Goal()
    {

    }
    public Goal(string name, string description, int points)
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