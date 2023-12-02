using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        Console.WriteLine("Welcome to your Daily Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");

        while (true)
        {
            Console.WriteLine(
                "1) Add New Entry\n"
                + "2) Display Entries\n"
                + "3) Save Entries\n"
                + "4) Load Entries\n"
                + "5) Quit"
            );

            Console.Write("Which option do you choose? ");
            string userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.SaveToFile();
                    break;
                case 4:
                    journal.LoadFromFile();
                                
            }
        }



    }
}
