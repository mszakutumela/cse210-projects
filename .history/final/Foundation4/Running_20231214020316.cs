using System;

public class Running : Activity
{
    private double _distance;

    public virtual double GetDistance()
    {
        
        
    }
    public virtual double GetSpeed()
    {
        
    }         
    
    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return summary;
    }
}