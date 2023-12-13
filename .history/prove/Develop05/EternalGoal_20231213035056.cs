using System;

// This is a child class. This goal doesn't get ticked off.
public class EternalGoal : Goal
{
    private int _counter;

    public EternalGoal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = 20;
        _counter = 0;
    }

    public EternalGoal()
    {
        _shortName = "Name of Eternal Goal";
        _description = "Description of Eternal Goal";
        _points = points;
        _counter = 0;
    }

    public override void CreateChildGoal()
    {
        CreateParentGoal();
    }

    public override void RecordEvent()
    {
        _counter++;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void GoalTickOff()
    {
        Console.WriteLine($"[ ] {_shortName} ({_description})");
    }

    public override int SumTotalPoints()
    {
        int totalPoints = _points;

        return totalPoints; 

    }

    public override string GetStringRepresentation()
    {
        string line = $"Eternal Goal: {_shortName} | description: {_description} | points: {_points.ToString()} ";

        return line;
    }
}