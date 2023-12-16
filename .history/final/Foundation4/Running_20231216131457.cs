using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(name, date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return 
        
    }
    public override double GetSpeed()
    {
        
    }         
    
    public override double GetPace()
    {
        
    }
    
}