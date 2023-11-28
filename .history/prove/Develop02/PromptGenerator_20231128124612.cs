using System;

public class PromptGenerator
{
    // public List<string> _prompts;

    public static string[] _prompts = {
        "How did I see the hand of the Lord in my life today?",
        "Write of a time when you were brave? What gave you the courage to be brave?",
        "What would you do differently or what would you like to change?",
        "Can you describe yourself in five positive words?",
        "What are you most grateful for?",
        "What helps you to smile, even if you don't feel like it?",
    };
    public List<string> _promptGenerator = new List<string> (_prompts);

    public PromptGenerator()
    {

    }

    public void DisplayPrompts()
    {
        var random = new Random();
        int index = random.Next(_promptGenerator.Count);
        string PromptGenerator = _promptGenerator[index];
        Console.WriteLine($"{_promptGenerator}");
    }

    public string GetRandomPrompt()
    {
        

        for (int i = 1; i < _prompts.Count; i++)
        {
             Random randomGenerator = new Random();
             string prompt = randomGenerator.Next(_prompts[i]);
             Console.WriteLine(prompt);
            //  Console.WriteLine(menus[i]);             
        }
        Random randomGenerator = new Random();
        // string prompt = randomGenerator.Next(_prompts);
        int index = randomGenerator.Next(_prompts.Count);

        return "";

    }  
}

