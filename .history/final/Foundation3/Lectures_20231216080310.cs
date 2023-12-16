using System;

public class Lectures : Events
{
    private string _speaker {get; set;}
    private int _capacity {get; set;}

    public Lectures(string title, string description, string date, string time, string address, string type, string speakerName, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speakerName;
        _capacity = capacity;
    }

    public string DisplayFullLectureDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"Spe: {_title}");
        Console.WriteLine($"Description: {_description}");
    }
}