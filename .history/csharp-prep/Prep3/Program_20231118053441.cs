using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        Console.Write("What is your guess? ");
        string guessInput = Console.ReadLine();
        int guessNumber = int.Parse(guessInput);

        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Higher");            
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Lower");
        }
        if (magicNumber == guessNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        while (magicNumber != guessNumber)
        {
            if (magicNumber > guessNumber)
            {
                Console.Write("Higher"); 
            }
            else if (magicNumber < guessNumber)
            {
                Console.Write("Lower");
            }
            if (magicNumber == guessNumber)
            {
                Console.Write("You guessed it!");
            }
        }
    }
}