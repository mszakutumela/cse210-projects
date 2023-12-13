using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine();

        string userInput = " ";
        string goalType = " ";

        GoalManager goals = new();

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
            Console.WriteLine();Console.WriteLine("The Types of Goals are: ");
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

            switch(userInput)
             {
                case "1":

                    goals.CreateGoal();
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
                    goals.RecordGoalEvent();

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
}