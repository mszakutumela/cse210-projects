public class Entry
{
    public s
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}: - Prompt: {_promptText}?");
    }

}