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
        ShowCountDown(3);
        Console.WriteLine();
        Console.WriteLine("Breath out...");
        Shoe
    }

}