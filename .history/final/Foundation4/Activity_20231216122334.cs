using System;

public class Activity
{
    protected string _activityName;
    protected string _date;
    protected int _length;
    
    public Activity(string name, string date, int minutes)
    {
        _activityName = name;
        _date = date;
        _length = minutes;
    }

    public virtual double Distance()
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