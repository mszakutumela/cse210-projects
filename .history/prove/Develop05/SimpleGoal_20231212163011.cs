using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool goalStatus)
    {
        _shortName = name;
        _description = descriptionl";
        _points = 20;
        _goalStatus = sta;
    }

    public SimpleGoal()
    {
        _shortName = "Name of Simple Goal";
        _description = "Description of Simple Goal";
        _points = 20;
        _goalStatus = false;
    }


}