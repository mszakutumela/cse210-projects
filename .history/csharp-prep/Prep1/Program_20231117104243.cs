 using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write();
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");

    }
}