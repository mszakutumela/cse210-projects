using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
    }
}