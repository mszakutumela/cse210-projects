using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

        Fraction fraction1 = new Fraction();
        fraction1._numerator = 1;
        fraction1._denominator = 1;
        Console.WriteLine(fraction1.Fraction());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.Fraction());
        
        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.Fraction());       
        
    }
}

        Job job1 = new Job();
        job1._companyName = "Adobe Inc";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2012;
        job1._endYear = 2015;
        

        Job job2 = new Job();
        job2._companyName = "Google";
        job2._jobTitle = "Graphic Designer";
        job2._startYear = 2015;
        job2._endYear = 2021;     