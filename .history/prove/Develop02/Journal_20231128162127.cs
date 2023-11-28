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
        Console.Write("Create a file name for your journal. What is the filename? ");
        string filename = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("Date,Prompt,userResponse");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.DisplayJournalDetails()}");
            } 
        }
        Console.WriteLine("Saved");
    }

    public void LoadFromFile(string file)
    {
        Console.Write("What is the filename? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists)
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