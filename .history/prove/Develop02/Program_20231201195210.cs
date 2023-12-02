using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to your Daily Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");

        Console.WriteLine(
            "1) Add New Entry\n"
            + "2) Display Entries\n"
            + "3) Save Entries\n"
            + "4) Load Entries\n"
            + "5) Quit"
        );

        Console.Write("Which option do you choose? ");
        string userChoice = int.Parse(Console.ReadLine());
        }


    }
}
