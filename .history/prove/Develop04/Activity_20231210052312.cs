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
        return _duration;
    }

    public void ShowSpinner(int numberOfSeconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;
        DateTime FutureTime = GetFutureTime(5);

        while (DateTime.Now < FutureTime)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            } 
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }

    public void ShowCountDown(int numberOfSeconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int)
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready!!");
        ShowSpinner(6);
    }







}