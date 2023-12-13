using System;
using System.IO;

// This is a child class. This goal gets ticked off. I also has it's own checklist.
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int _bonusPoints, int )
    {
        _shortName = name;
        _description = description;
        _points = points;
        _goalStatus = status;
    }

    public ChecklistGoal()
    {
        
    }

}