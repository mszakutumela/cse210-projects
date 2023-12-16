using System;

public class Receptions : Events
{
    private string _rsvpEmail {get; set;}

    public Receptions(string title, string description, string date, string time, string address, string type, string email) : base(title, description, date, time, address, type)
    {
        _rsvpEmail = email;
    }

    public void Get

    public string DisplayFullReceptionDetails()
    {
        DisplayFullDetails();
        Console.WriteLine($"RSVP E-mail Address: {_rsvpEmail}");
    }
}