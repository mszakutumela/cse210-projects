using System;

// Step 4: Create the Square class
// 1. In a new file, create the Square class.
// 2. Make sure this class inherits from the base class.
// 3. Create a constructor that accepts the color and the side, and then call the base constructor with the color.
// 4. Create the _side attribute as a private member variable.
// 5. Override the GetArea() method from the base class and fill in the body of this function to return the area.

public class Square : Shape
{
    private double _side;

    public Square (string color, double side) : base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side
    }
}