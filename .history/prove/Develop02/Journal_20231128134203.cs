using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries; 
    public PromptGenerator promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new 
    }
    
    public void AddEntry(Entry newEntry)
    {
        Console.Write(newEntry + " ");
        string response = Console.ReadLine();
        

        Journal.AddEntry(newEntry); 
    }

    public void DisplayEntries()
    {

    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}