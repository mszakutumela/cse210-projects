using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.", 
    };
    private List<string> _promptsQues = new() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int index = random.Next(0,_prompts.Count);

        return _prompt[index];
    }

    public string GetPromptQuestions()
    {
        Random random = new();
        int index = random.Next(0,_promptsQues.Count);

        return _promptsQues[index];
    }

    public void RunActivity()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"___ {prompt} ___");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();
        
        while (currentTime <= futureTime)
        {
            string promptQues = GetPromptQuestions();
            Console.Write(pro"Breath in...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine("Breath out...");
            ShowCountDown(8);
            currentTime = DateTime.Now;
        }
        
    }
}            