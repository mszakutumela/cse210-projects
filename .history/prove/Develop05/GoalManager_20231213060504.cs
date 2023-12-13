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

    public void DisplayPlayerInfo(int score)
    {
        Console.WriteLine($"You have {score} points.");
        Console.WriteLine();
    }

    public void Start()
    {
        string userInput = " ";

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
                    BreathingActivity breathingActivity = new();
                    breathingActivity.RunActivity();
                    breathingActivity.RunBreathActivity();
                    breathingActivity.DisplayEndingMessage();

                    // breathingLog++;
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.RunActivity();
                    reflectingActivity.RunReflectActivity();
                    reflectingActivity.DisplayEndingMessage();

                    // reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new();
                    listingActivity.RunActivity();
                    listingActivity.RunListActivity();
                    listingActivity.DisplayEndingMessage();

                    // listingLog++;
                    break;
                
                case "4":
                    Environment.Exit(0);
                    break; 
                default:
                    Console.WriteLine("Please enter the number from the menu option. ");
                    Console.WriteLine();
                    break;
             }
        }
    }

}