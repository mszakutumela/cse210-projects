using System;

public class Swimming : Activity
{
    private double _s;

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
        double speed = GetDistance() / (_time * 60);

        return speed; 
    }         
    
    public override double GetPace()
    {
        double pace = _time / GetDistance();

        return pace;
    }   
}