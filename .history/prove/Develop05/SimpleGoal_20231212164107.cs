using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool status)
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
            
        }
    }


}