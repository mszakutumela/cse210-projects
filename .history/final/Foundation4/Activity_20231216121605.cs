using System;

public class Activity
{
    protected DateTime _date;
    protected int _;

    public Activity()
    {

    }

    public virtual double GetDistance()
    {
        return 0;
        
    }
    public virtual double GetSpeed()
    {
        return 0;
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