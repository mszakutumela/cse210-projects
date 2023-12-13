using System;
using System.IO;

// This is a child class. This goal gets ticked off. I also has it's own checklist.
public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int amountCompleted, int target)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
        _target = target;
        
    }

    public ChecklistGoal()
    {
        
    }

    public override void CreateChildGoal()
    {
        CreateParentGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string totalTarget = Console.ReadLine();
        _target = Convert.ToInt32(totalTarget);

        Console.Write("What is the bonus for accomplishing it that many times? ")
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

        totalPoints = _amountCompleted * _points

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
        string line = $"Checklist Goal: {_shortName} | description: {_description} | points: {_points.ToString()} | {_bonusPoints.ToString()} | {_.ToString()}";

        return line;
    }



}