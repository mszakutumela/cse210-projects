using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, double laps) : base(name, date, minutes)
    {
        _activityName = "Swimming";
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * (50 / 1000);

        return distance;        
    }
    public override double GetSpeed()
    {
        
    }         
    
    public override double GetPace()
    {
        
    }

    public override string GetSummary()
    {
        
    }
}