using System;

public class Activity
{
    protected string _activityName;
    protected string _date;
    protected int _time;
    
    public Activitstring date, int minutes)
    {
        _activityName = name;
        _date = date;
        _time = minutes;
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
        return $"{_date} | {_activityName} | - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}