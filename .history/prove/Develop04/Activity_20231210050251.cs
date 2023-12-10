using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = " ";
        _description = " ";
        _duration = 0;
    }

    public void SetName()
    {
        _name = name;
    }

    public void SetDescription()
    {
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void AskForDuration()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string durationInSeconds = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationInSeconds));
    }

    public int GetDuration()
    {
        return duration
    }







}