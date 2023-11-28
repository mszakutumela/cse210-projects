using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to your Daily Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");

        List<string> menus = new List<string>();
        menus.Add(" ");
        menus.Add("Write entry");
        menus.Add("Display entry");
        menus.Add("Load entry");
        menus.Add("Save entry");
        menus.Add("Quit journal");

        // Console.WriteLine(menus.Count);
        choice = 0;

        // Console.WriteLine("Please select one of the following choices: ");
        for (int i = 1; i < menus.Count; i++)
        {
             string menu = menus[i];
             Console.WriteLine($"{i}. {menu}");
            //  Console.WriteLine(menus[i]);             
        }

        Console.Write("Which option do you choose? ");
        string userChoice = Console.ReadLine();
        int choice = int.Parse(userChoice); 

        while (choice != 5)
        {
            for (int i = 1; i < menus.Count; i++)
            {
                string menu = menus[i];
                Console.WriteLine($"{i}. {menu}");
            //  Console.WriteLine(menus[i]);             
            }

            Console.Write("Which option do you choose? ");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice); choice = userChoice;

            if (action == 1)
            {
                GetRandomPrompt();
                response = GetUserResponse();


            }

        }


    }
}
