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

    public void SaveGoals(string filename)
    {
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            int totalPoints = GetScore();
            outputFile.WriteLine(totalPoints.ToString());

            foreach ( goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            } 
        }
        Console.WriteLine("Saved!");
    }

    public void LoadGoals(string filename)
    {
        _goals.Clear();

        // string filename = " ";
        Console.Wite("What is the filename? ");
        filename = Console.ReadLine();

        try
        {
            string[] readText = File.ReadAllLines(filename);

            _score = Convert.ToInt32[readText[0]];

            for (int i = 1; i < readText.Count(); i++)
            {
                string[] parts = lines[i].Split("|");

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new();
                    _goals.Add(simpleGoal);
                }

                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new();
                    _goals.Add(eternalGoalGoal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new();
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

        foreach (Goal goal in goals)
        {
            totalPoints += goal.SumTotalPoints();
        }

        _score = totalPoints;

        return totalPoints;
    }

    public void RecordGoalEvent(string goalNumber)
    {
        Console.Write("Which goal did you accomplish? ");
        goalNumber = Console.ReadLine(Convert.ToInt32(goalNumber) - 1);

        if (_goals[goalNumber].IsComplete() == false)
        {
            _goals[goalNumber].RecordEvent();

            int totalPoints = _goals[goalNumber].SumTotalPoints();

            score += totalPoints;

            Console.WriteLine($"Congratulations! You have earned {totalPoints.ToString()} points! ");
            Console.WriteLine($"You now have {_score} points.");
        }

        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
        
    }





}