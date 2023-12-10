using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunActivity()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        Console.WriteLine();
        Console.Write("Breath in...");
        ShowCountDown(2);
        Console.WriteLine();
        Console.WriteLine("Breath out...");
        ShowCountDown(3);
    }

    while (currentTime <= futureTime)
    {
        Console.WriteLine();
        Console.Write("Breath in...");
        ShowCountDown(4);
        Console.WriteLine();
        Console.WriteLine("Breath out...");
        ShowCountDown(5);
    }

}