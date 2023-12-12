using System;

// This is the parent class.
public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _goalStatus;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public Goal()
    {
        _shortName = "Test shortName";
        _description = "Test Description";
        _points = 20;
        _goalStatus = false;
    }

    protected void CreateParentGoal()
    {
        Console.Write("What is the name of your goal? ");
        _shortName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();
        _points = Convert.ToInt32(goalPoints);

        _goalStatus = false;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetStringRepresentation()
    {
        string line = " ";

        return line;
    }

    public virtual void CreateChildGoal()
    {

    }

    public virtual void GoalList()
    {

    }

    public virtual int SumTotalPoints()
    {
        
    }



}