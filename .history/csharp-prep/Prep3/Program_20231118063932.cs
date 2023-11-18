using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        // Console.Write("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int magicNumber = int.Parse(userInput);
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator

        int guessNumber = -1;

        // Console.Write("What is your guess? ");
        // string guessInput = Console.ReadLine();
        // int guessNumber = int.Parse(guessInput);

        // if (magicNumber > guessNumber)
        // {
        //     Console.WriteLine("Higher");            
        // }
        // else if (magicNumber < guessNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // if (magicNumber == guessNumber)
        // {
        //     Console.WriteLine("You guessed it!");
        // }
        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            // string guessInput = Console.ReadLine();
            // int guessNumber = int.Parse(guessInput);
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher"); 
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}