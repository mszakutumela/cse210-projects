using System;

public class Receptions : Events
{
    private string _rsvpEmail {get; set;}

    public Receptions(string title, string description, string date, string time, string address, string type, string speakerName, int capacity) : base(title, description, date, time, address, type)
    {

    }

    public string GetFullDetails()
    {
        
    }
}