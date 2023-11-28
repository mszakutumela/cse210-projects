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
        en
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