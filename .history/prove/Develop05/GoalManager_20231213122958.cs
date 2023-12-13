using System;
using System.IO;

// This is a manager class.
public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    

    public int GetScore()
    {
        int points = _score;

        return points;
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].GoalTickOff();
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        string fileName = " ";
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalPoints = GetScore();
            outputFile.WriteLine(totalPoints.ToString());

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            } 
        }
        Console.WriteLine("Saved!");
    }

    public void LoadGoals()
    {
        _goals.Clear();

        string fileName = " ";
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();

        try
        {
            string[] readText = File.ReadAllLines(fileName);

            _score = Convert.ToInt32(readText[0]);

            for (int i = 1; i < readText.Count(); i++)
            {
                string[] parts = readText[i].Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                    _goals.Add(simpleGoal);
                }

                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    _goals.Add(eternalGoal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    CheckListGoal checklistGoal = new(parts[1], parts[2], );
                    _goals.Add(checklistGoal);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to file denied.");
        }     
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int CalculateSumTotalPoints()
    {
        int totalPoints = _score;

        foreach (Goal goal in _goals)
        {
            totalPoints += goal.SumTotalPoints();
        }

        _score = totalPoints;

        return totalPoints;
    }

    public void RecordGoalEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        string goalNumber = Console.ReadLine();
        int goalNumberInt = Convert.ToInt32(goalNumber) - 1;

        if (_goals[goalNumberInt].IsComplete() == false)
        {
            _goals[goalNumberInt].RecordEvent();

            int totalPoints = _goals[goalNumberInt].SumTotalPoints();

            _score += totalPoints;

            Console.WriteLine($"Congratulations! You have earned {totalPoints.ToString()} points! ");
            Console.WriteLine($"You now have {_score} points.");
        }

        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
        
    }





}