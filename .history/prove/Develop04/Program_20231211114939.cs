using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine();

        string userInput = " ";
        // int breathingLog = 0;
        // int reflectingLog = 0;
        // int listingLog = 0;

        // void DisplayLog()
        // {
        //     Console.WriteLine("Activity Log - Current Session");
        //     Console.WriteLine($"Breathing Activity: {breathingLog}");
        //     Console.WriteLine($"Reflecting Activity: {reflectingLog}");
        //     Console.WriteLine($"Listing Activity: {listingLog}");
        //     Console.WriteLine();
        // }

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(
                "1. Add New Entry\n"
                + "2. Display Entries\n"
                + "3. Save Entries\n"
                + "4. Quit"
            );
             Console.WriteLine("Select a choice from the menu:");
             
             userInput = Console.ReadLine();
             Console.WriteLine(userInput);

             switch(userInput)
             {
                case "1":
                    BreathingActivity breathingActivity = new();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.RunActivity();
                    breathingActivity.DisplayEndingMessage();

                    // breathingLog++;
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.RunActivity();
                    reflectingActivity.DisplayEndingMessage();

                    // reflectingLog++;
                    break;

                case "3":
                    ListingActivity listingActivity = new();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.RunListActivity();
                    listingActivity.DisplayEndingMessage();

                    // listingLog++;
                    break;
                
                case "4":
                    Environment.Exit(0);
                    break; 
                default:
                    Console.WriteLine("Please enter the number from the menu option. ");
                    break;
             }
        }

    }
}