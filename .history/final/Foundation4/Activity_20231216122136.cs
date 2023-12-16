using System;

public class Activity
{
    protected string _activityName;
    protected string _date;
    protected int _minute;
    
    public Activity(string name, string date, int minutes)
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