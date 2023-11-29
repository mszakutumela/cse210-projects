using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.Fraction());
        
        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction1.Fraction());
        
        Fraction fraction3 = new Fraction(6, 7);
              
        
    }
}

     