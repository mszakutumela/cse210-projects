using System;

public class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(string date, int minutes, double speed) : base(name, date, minutes)
    {
        _activityName = "Stationary Bicycle";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * (_time / 60);

        return distance;

    }
    public override double GetSpeed()
    {
        return speed;
    }         
    
    public override double GetPace()
    {
        double pace = 60 / _speed;

        return pace;
    }

    
    }
}