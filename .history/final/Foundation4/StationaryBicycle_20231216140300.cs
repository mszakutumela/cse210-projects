using System;

public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(string date, int minutes, double speed) : base(name, date, minutes)
    {
        _activityName = "Stationary Bicycle";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _length     
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