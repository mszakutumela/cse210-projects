using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new();
    
    public void AddEntry(Entry newEntry)
    {
        Entry userEntry = new E();
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

        if (File.Exists(_userFileName))
        {
            string[] lines = System.IO.File.ReadAllLines(_userFileName);
            foreach (string line in lines)
            {
                string[] entries = line.split(",");

                Entry userEntry = new Entry();
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