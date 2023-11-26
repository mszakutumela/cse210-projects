public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}