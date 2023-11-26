public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_} ({_companyName}) {_startYear}-{_endYear}");
    }

}