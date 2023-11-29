using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.Fraction());

        Fraction fraction2 = new Fraction();
        Console.WriteLine(fraction2.Fraction(6));
        
        Fraction fraction3 = new Fraction();
        Console.WriteLine(fraction3.Fraction(6, 7));       
        
    }
}

        