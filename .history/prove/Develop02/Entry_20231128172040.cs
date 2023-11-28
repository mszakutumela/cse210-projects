using System;

public class Entry
{
    public GetRandomPrompt promptGenerator
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    
    }

    public void GetUserResponse()
    {
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void DisplayJournalDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}?");
        Console.WriteLine($"Entry: {_entryText}");

    }

}