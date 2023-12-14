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
    
    public virtual doubleGetPace()
    {
        return 0;
    }

GetSummary(): virtual string        |
|___________________________
}