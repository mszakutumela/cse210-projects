using System;
using System.IO;

// This is a child class. This goal gets ticked off. I also has it's own checklist.
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public CGoal(string name, string description, int points, bool status)
    {
        _shortName = name;
        _description = description;
        _points = points;
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