using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to your Daily Journal Program!");
        // Console.WriteLine("Please select one of the following choices: ");

        List<string> menus = new List<string>();
        menus.Add("Write entry");
        menus.Add("Display entry");
        menus.Add("Load entry");
        menus.Add("Save entry");
        menus.Add("Quit journal");

        // Console.WriteLine(menus.Count);

        int Choice = 0;

        while (Choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            for (int i = 0; i < menus.Count; i++)
            {
                string menu = menus [i];
                Console.WriteLine($"{i}. {menu}");
                Console.Write("Which option do you choose? ");
                choice
                string userChoice = Console.ReadLine();
                int choice = int.Parse(userChoice);



            }
        }


// string userInput = 
//         int percentage = int.Parse(userInput);

    //     while action != 5:
    // print("\nPlease select one of the following: ")
    // for i in range(1, len(menus)):
    //     menu = menus[i]
    //     print(f"{i}. {menu}")
    // action = 0
    // action = int(input("Please enter an action: "))







    }
}