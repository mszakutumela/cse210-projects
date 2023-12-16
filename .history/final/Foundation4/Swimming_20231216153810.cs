using System;

public class Swimming : Activity
{
    private double _pace;

    public Swimming(string date, int minutes, double pace) : base(date, minutes)
    {
        _activityName = "Swimming";
        _pace = pace;
    }

    public override double GetDistance()
    {
        double distance = _pace * 50 / 1000);

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