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
        Console.WriteLine()


    }
}