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

        string letter = "";

        if (percentage >= 90)
        {
            // Console.WriteLine("A");
            letter = "A";
            
        }
        else if (percentage >= 80)
        {
            // Console.WriteLine("B");
            letter = "B";
        }
        else if (percentage >= 70)
        {
            // Console.WriteLine("C");
            letter = "C";
        }
        else if (percentage >= 60)
        {
            // Console.WriteLine("D");
            letter = "D";
        }
        else if (percentage < 60)
        {
            // Console.WriteLine("F");
            letter = "F";
        }

        

        if (percentage >= 70)
        {
            Console.Write("You passed! Congratulations!");
        }
        else 
        {
            Console.Write("You failed! Don't give up!");
        }
    }
}