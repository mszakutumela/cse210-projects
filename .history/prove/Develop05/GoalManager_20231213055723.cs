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

    public void DisplayPoints(int score)
    {
        Console.WriteLine($"You have {score} points.");
        
    }

    public void Start()
    {
        string userInput = " ";

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(
                "1. Start breathing activity\n"
                + "2. Start reflecting activity\n"
                + "3. Start listing activity\n"
                + "4. Quit"
            );
             Console.Write("Select a choice from the menu: ");
             
             userInput = Console.ReadLine();
            //  Console.WriteLine(userInput);
            Console.WriteLine();
    }


}