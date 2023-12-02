using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    private PromptGenerator promptGen = new(); /* The comment `/* In C#, `new();` is a shorthand syntax for
    creating an instance of a class without explicitly
    specifying the constructor arguments. It is called a
    parameterless constructor invocation. */
    
    public void WriteEntryDetails()
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptGen.GetRandomPrompt();
        Console.Write(_promptText + "\n> ");
        _entryText = Console.ReadLine();
    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}?");
        Console.WriteLine($"Entry: {_entryText}");
    }
}