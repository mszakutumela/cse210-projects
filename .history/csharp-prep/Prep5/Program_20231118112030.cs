using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber ()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favNumber = int.Parse(userInput);
            return favNumber;
        }
        static int SquareNumber (int number)
        {
            // int favNumber = PromptUserNumber();
            int square = number * number;
            return square;
        }

        static void DisplayResults (string name, int square)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {square}");
        }
        
    }
    
}