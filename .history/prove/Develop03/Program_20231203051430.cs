using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all thine heart; and learn not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.Clear();
        Console.WriteLine(scriptureReference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            break;

            if(!scripture.HideRandomWords(0))
            {
                Console.WriteLine("Well done! You memorized the scripture.");
            }
            break;
        }
        Console.Clear();
        scripture.GetDisplayText();
        
    }
}