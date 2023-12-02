using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new();
    
    public void AddEntry()
    {
        Entry userEntry = new();
        userEntry.WriteEntryDetails();
        _entries.Add(userEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntryDetails();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            } 
        }
        Console.WriteLine("Saved");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(_userFileName))
        {
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] data = line.Split("|");

                Entry userEntry = new();
                userEntry.GenerateDate() = entries[0];
                userEntry.GetPrompt() = entries[1];
                userEntry.GetUserResponse = entries[2];
                
                Journal.AddEntry(userEntry);
            }
        }
    }

}

// string filename = "myFile.txt";
// string[] lines = System.IO.File.ReadAllLines(filename);

// foreach (string line in lines)
// {
//     string[] parts = line.Split(",");

//     string firstName = parts[0];
//     string lastName = parts[1];
// }