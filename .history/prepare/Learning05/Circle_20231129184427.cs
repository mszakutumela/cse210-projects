using System;

// Step 6: Create the Rectangle and Circle classes
// 1. Repeat the steps above for the Rectangle and Circle classes, putting 
// hem each in their own files, storing the necessary variables, and overriding 
// the GetArea() for each.

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, string radius) : base(color)
    {
        _radius = " ";
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

}