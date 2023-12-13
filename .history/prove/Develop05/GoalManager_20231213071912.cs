using System;
using System.IO;

// This is a manager class.
public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public GoalManager()
    {

    }

    public int GetScore()
    {
        int points = _score;

        return points;
    }

    public void DisplayPlayerInfo(int points)
    {
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
    }

    public void Start()
    {
        string userInput = " ";
        string goalType = " ";

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(
                "1. Create New Goal\n"
                + "2. List Goals\n"
                + "3. Save Goals\n"
                + "4. Load Goals\n"
                + "5. Record Event\n"
                + "6. Quit"
            );
            Console.Write("Select a choice from the menu: ");
            
            userInput = Console.ReadLine();
            Console.WriteLine();

            switch(userInput)
             {
                case "1":

                    goals.ListGoalNames();
                    break;

                case "2":
                    goals.ListGoalDetails();
                    break;

                case "3":
                    goals.SaveGoals();
                    break;

                case "4":
                    goals.LoadGoals();
                    break;

                case "5":
                    goals.RecordGoalEvent()

                case "6":
                    Environment.Exit(0);
                    break; 

                default:
                    Console.WriteLine("Please select a valid number from the menu options. ");
                    Console.WriteLine();
                    break;    

             }
             
        }
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine(
                        "1. Simple Goal\n"
                        + "2. Eternal Goal\n"
                        + "3. Checklist Goal\n"
                    );
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    switch(goalType)
                    {
                        case "1":
                            SimpleGoal newSimpleGoal = new();
                            newSimpleGoal.CreateChildGoal();
                            goals.addGoal(newSimpleGoal);
                            break;

                        case "2":
                            EternalGoal newEternalGoal = new();
                            newEternalGoal.CreateChildGoal();
                            goals.addGoal(newEternalGoal);                    
                            break;

                        case "3":
                            ChecklistGoal newChecklistGoal = new();
                            newChecklistGoal.CreateChildGoal();
                            goals.addGoal(newChecklistGoal);
                            break;
                
                        default:
                            Console.WriteLine("Invalid goal type. Please try again. ");
                            Console.WriteLine();
                            break;
                    }
                    
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

    public void SaveGoals(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            int 
            foreach (Entry goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            } 
        }
        Console.WriteLine("Saved!");
    }



}