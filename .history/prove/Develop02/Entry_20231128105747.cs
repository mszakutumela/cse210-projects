using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public EntryText()
    {
         
    }
    
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}?");
        

    }

}