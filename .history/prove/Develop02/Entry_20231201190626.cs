using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    private PromptGenerator promptGen = new();
    
    public void WriteEntryDetails()
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptGen.GetRandomPrompt();Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}?");
        Console.WriteLine($"Entry: {_entryText}");

    }

}