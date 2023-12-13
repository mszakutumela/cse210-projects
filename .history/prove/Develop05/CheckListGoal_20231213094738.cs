using System;
// using System.IO;

// This is a child class. This goal gets ticked off. I also has it's own checklist.
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    // public ChecklistGoal(string name, string description, int points, bool status, int bonusPoints, int amountCompleted, int target)
    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints, int amountCompleted, int target)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _goalStatus = status;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
        _target = target;        
    }

    public ChecklistGoal()
    {
        _shortName = "Name of Checklist Goal";
        _description = "Description of Checklist Goal";
        _points = 20;
        _goalStatus = false;
        _bonusPoints = 0;
        _amountCompleted = 0;
        _target = 0;
    }

    public override void CreateChildGoal()
    {
        CreateParentGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string totalTarget = Console.ReadLine();
        _target = Convert.ToInt32(totalTarget);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonus);

        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= target)
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
        Console.WriteLine($"[{goalStatusIcon}] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}");
    }

    public override int SumTotalPoints()
    {
        int totalPoints = 0;

        totalPoints = _amountCompleted * _points;

        bool status = IsComplete();
        
        if (status == true)
        {
            totalPoints += _bonusPoints;
        }
        else
        {
            totalPoints = 0;
        }

        return totalPoints;
    }

    public override string GetStringRepresentation()
    {
        string line = $"Checklist Goal: {_shortName} | description: {_description} | points: {_points.ToString()} | {_bonusPoints.ToString()} | {_amountCompleted.ToString()} | {_target.ToString()}";

        return line;
    }
}