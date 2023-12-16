using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Console.WriteLine();

        // Create activity list
        List<Activity> activityList = new();

        Running running = new("03 Nov 2022", 30, 4.8);
        activityList.Add(running);

        StationaryBicycle bicycle = new("15 Dec 2023", 45, 20);
        activityList.Add(bicycle);

        Swimming swimming = new("13 Oct 2023", 60, 10);
        activityList.Add(swimming);

        Console.WriteLine("----- Activities -----")
        Console.WriteLine();

        foreach (Activty activity in a)


    }
}