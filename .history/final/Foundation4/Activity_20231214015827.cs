using System;

public class Activity
{
    protected DateTime _date;
    protected int _minutes;

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

    public virtual double GetSummary(): virtual string        |
|___________________________
}