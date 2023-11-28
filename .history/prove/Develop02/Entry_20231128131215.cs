using System;

public class Entry
{
    public string _dateTime;
    public string _promptText;
    public string _entryText;
    
    public Entry()
    public void DisplayJournalDetails()
    {
        Console.WriteLine($"Date: {_dateTime} - Prompt: {_promptText}?");
        Console.WriteLine($"Entry: {_entryText}");

    }

}