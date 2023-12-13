using System;

// This is a child class. This goal doesn't get ticked off.
public class EternalGoal : Goal
{
    private int _counter;

    public Goal(string name, string description, int points, bool status)
    {
        _shortName = name;
        _description = description;
        _points = 20;
        _goalStatus = status;
    }

    public SimpleGoal()
    {
        _shortName = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 20;
        _goalStatus = false;
    }
}