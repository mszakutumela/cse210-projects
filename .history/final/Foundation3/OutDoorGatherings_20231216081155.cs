using System;

public class OutDoorGatherings : Events
{
    private string _weatherForecast;

    public OutDoorGatherings(string title, string description, string date, string time, string address, string type, string weather) : base(title, description, date, time, address, type)
    {
    {
        _weatherForecast = weather;
    }

    public string DisplayFullGatheringDetails()
    {
        Displa
    }
}