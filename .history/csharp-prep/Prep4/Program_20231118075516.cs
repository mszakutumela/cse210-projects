using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        int number = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());


        }
        
    }
}