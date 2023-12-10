using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _userList = new();

    public ListingActivity()
    {
        SetName("Listing Activity");
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

    }

}