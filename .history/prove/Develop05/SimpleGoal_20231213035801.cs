using System;

// This is a child class. This goal gets ticked off.
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool status)
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

    public bool Is

    public override void CreateChildGoal()
    {
        CreateParentGoal();
    }

    public override void RecordEvent()
    {
        if (_goalStatus == false)
        {
            _goalStatus = true;
        }
        else 
        {
            Console.WriteLine("This goal is completed!");
        }
    }

    public override bool IsComplete()
    {
        if(_goalStatus == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void GoalTickOff()
    {
        string goalStatusIcon = " ";
        bool status = IsComplete();
        if (status == true)
        {
            goalStatusIcon = "X";
        }
        else
        {
            goalStatusIcon = " ";
        }
        Console.WriteLine($"[{goalStatusIcon}] {_shortName} ({_description})");
    }

    public override int SumTotalPoints()
    {
        bool status = IsComplete();
        int totalPoints = 0;
        if (status == true)
        {
            totalPoints = _points;
        }
        else
        {
            totalPoints = 0;
        }

        return totalPoints;
    }

    public override string GetStringRepresentation()
    {
        string line = $"Simple Goal: {_shortName} | description: {_description} | points: {_points} | completed: {IsComplete().ToString()}";

        return line;
    }
    
}