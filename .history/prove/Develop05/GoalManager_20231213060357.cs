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
        }


}