using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        if (percentage >= 90)
        {
            Console.Write("A");
        }
        else if (percentage >= 80)
        {
            Console.Write("B");
        }
        else if (percentage >= 70);
        {
            Console.Write("C");
        }
        else if (percentage >= 60);
        {
            Console.Write("D");
        }
        else if (percentage < 60);
        {
            Console.Write("F");
        }
    }
}