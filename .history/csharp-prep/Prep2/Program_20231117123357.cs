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
        else if (percentage >= 80);
        {

        }
        else if (percentage >= 70);
        {
            
        }
        else if (percentage >= 60);
        {
            
        }
        else if (percentage < 60);
        {
            
        }
    }
}