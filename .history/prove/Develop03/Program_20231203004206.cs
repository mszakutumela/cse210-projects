using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all thine heart;"\n
        and learn not unto thine own understanding.\nIn all thy ways acknowledge him, and he shall\n
        direct thy paths.");
        Console.Clear();
        Console.WriteLine(scriptureReference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

        
    }
}