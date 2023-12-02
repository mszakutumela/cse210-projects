using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public void WriteEntryDetails()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = DatTime.Now.ToShortDateString();
        _promptText = GetRandomPrompt();
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}?");
        Console.WriteLine($"Entry: {_entryText}");

    }

}