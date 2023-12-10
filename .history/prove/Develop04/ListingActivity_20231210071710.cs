using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.", 
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(0,_prompts.Count);

        return _prompts[index];
    }
    
    public void RunActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you ");


    }

}