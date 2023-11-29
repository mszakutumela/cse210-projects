using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine();

// Step 5: Test the Square class
// 1. Return to the Main method in Program.cs to test your code.
// 2. Create a Square instance, call the GetColor() and GetArea() 
// methods and make sure they return the values you expect.

        Square squareArea = new Square("yellow", 3);
        string color = squareArea.GetColor();
        double area = squareArea.GetArea();
        // Console.WriteLine($"The {color} shape has an area of {area}");

// Step 6: Create the Rectangle and Circle classes
// 2. Test these classes back in Main and make sure they work as expected.

        Rectangle rectangleArea = new Rectangle("red", 5, 8);
        string color = rectangleArea.GetColor();
        double area = rectangleArea.GetArea();
        // Console.WriteLine($"The {color} shape has an area of {area}");

        Circle circleArea = new Circle("blue", 6);
        string color = circleArea.GetColor();
        double area = circleArea.GetArea();
        // Console.WriteLine($"The {color} shape has an area of {area}");

        Console.WriteLine($"The {color} shape has an area of {area}");

    }

}    
