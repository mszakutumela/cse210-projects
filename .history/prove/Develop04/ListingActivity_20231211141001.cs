using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new();
    private List<string> _listFromUser = new();

     private List<string> _prompts = new() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?", 
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        return _prompts[random.Next(0,_prompts.Count)];

        // return _prompts[index];
    }

    public string GetListFromUser()
    {

    }
    
    public void RunListActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"___ {prompt} ___");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
    }    

    public void ListingTimer()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        while (currentTime <= futureTime)
        {
            string promptQues = GetRandomPrompt();
            Console.Write("> ");
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }    

}