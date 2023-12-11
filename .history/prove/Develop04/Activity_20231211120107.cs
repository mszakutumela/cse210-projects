using System;
using System.IO;

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

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
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

    public void ShowSpinner(int seconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;
        DateTime futureTime = GetFutureTime(5);
        DateTime curee

        while (DateTime.Now < seconds)
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

    public void ShowCountDown(int seconds)
    {
        int timerPosition = 25;
        int timerWait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= seconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(seconds - i);
            Thread.Sleep(timerWait);
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready!!");
        ShowSpinner(6);
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        AskForDuration();
        GetReady();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new();
        currentTime = DateTime.Now;

        return currentTime;
    }

}