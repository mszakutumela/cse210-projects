using System;

public class Events
{
    private string _title {get; set;}
    private string _description {get; set;}
    private string _date {get; set;}
    private string _time {get; set;}
    private Address _address {get; set;}
    private string _eventType {get; set;}

    public Events(string title, string description, string date, string time, string address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = type;
    }

    public string GetStandardDetails()
    {
        
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Date: {_date}");
    }

    public string GetFullDetails()
    {

    }

    public string GetShortDescription()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_title}");
        Console.WriteLine($"Date: {_date}");
    }

}