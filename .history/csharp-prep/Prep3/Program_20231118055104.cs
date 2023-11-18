using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        
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
            Console.Write("What is your guess? ");
            string guessInput2 = Console.ReadLine();
            int guessNumber2 = int.Parse(guessInput2);

            if (magicNumber > guessNumber2)
            {
                Console.WriteLine("Higher"); 
            }
            else if (magicNumber < guessNumber2)
            {
                Console.WriteLine("Lower");
            }
            if (magicNumber == guessNumber2)
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}