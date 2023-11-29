using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

// Step 4: Create the Constructors
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);

// Step 5: Create the Getters and Setters    
        // Fraction fraction1 = new Fraction();
        // fraction1.SetTopNumber(3);
        // fraction1.SetBottomNumber(5);
        // Console.WriteLine(fraction1.GetTopNumber());
        // Console.WriteLine(fraction1.GetBottomNumber());

// Step 6: Create methods to return the representations  
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        
        Fraction fraction3 = new Fraction(6, 7);
        Fraction fraction4 = new Fraction(6, 7);


              
    
}

