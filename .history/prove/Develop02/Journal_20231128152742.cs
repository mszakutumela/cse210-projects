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

        _entries.Add(userEntry);
    //     Journal.AddEntry(userEntry); 
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in  )
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}