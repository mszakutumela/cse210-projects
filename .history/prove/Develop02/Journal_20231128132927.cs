using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries; 

    public Journal()
    {
        _entries = new List<Entry>();
    }
    
    public void AddEntry(Entry newEntry)
    {
        Console.Write(newEntry + " ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        _entries.Add(new Entry)
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