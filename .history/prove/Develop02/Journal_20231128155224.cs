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
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GetPrompt();
        userEntry.GetUserResponse();

        // _entries.Add(userEntry);
        Journal.AddEntry(userEntry); 
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            DisplayJournalDetails();
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("Create a file name for your journal")
    }

    public void LoadFromFile(string file)
    {

    }

}