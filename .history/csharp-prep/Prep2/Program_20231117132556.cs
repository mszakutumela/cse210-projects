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
        string extras = "";

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
        Stretch Chall
        if (letter == "F")
        else if ((percentage % 10) >= 7)
        {
            if (letter == "A")
            {
                extras = "";
            }
            else 
            {
                extras = "+";
            }
        }

if letter == 'F':
    additional = ''
    if letter == 'A':
        additional = ''
    else:
        additional = '+'

elif (percentage % 10) < 3:
    additional = '-'
    
else:
    additional = ''

        Console.WriteLine($"Your grade is: {letter} {extras}");
        Console.WriteLine();

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