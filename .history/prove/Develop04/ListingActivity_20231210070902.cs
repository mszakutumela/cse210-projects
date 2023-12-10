using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _userList = new();

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
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