using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        int number = 0;
        int sum = 0;
        int average

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }


        }

        // 1. Compute the sum, or total, of the numbers in the list.
        foreach (int numb in numbers)
        {
            sum += numb;
        }
        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average of the numbers in the list.



    }
}