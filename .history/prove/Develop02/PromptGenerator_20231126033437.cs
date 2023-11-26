public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        return Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}