using System;

public class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity()
    {

    }

    public virtual double GetDistance(): virtual double       |
| GetSpeed(): virtual double          |
| GetPace(): virtual double           |
| GetSummary(): virtual string        |
|___________________________
}