using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries; 
    public PromptGenerator promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        promptGenerator = new PromptGenerator
    }
    
    public void AddEntry(Entry newEntry)
    {
        string prompt = p
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