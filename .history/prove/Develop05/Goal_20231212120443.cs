using System;

// This is the parent class.
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _goalStatus;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public Goal()
    {
        _shortName = "Test shortName";
        _description = "Test Description";
        _points = 20;
        _goalStatus = false;
    }

    protected void RecordEvent()
    {
        Console.Write("What is the name of your goal? ");
        _shortName =
    }


}