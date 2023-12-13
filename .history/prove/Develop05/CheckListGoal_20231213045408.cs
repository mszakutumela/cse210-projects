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
        
    }

}