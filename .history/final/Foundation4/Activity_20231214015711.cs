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
    puGetSpeed(): virtual double          


| GetPace(): virtual double           |
| GetSummary(): virtual string        |
|___________________________
}