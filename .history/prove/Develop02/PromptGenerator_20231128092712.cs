using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        string[] _prompts = {
            "How did I see the hand of the Lord in my life today?",
            "Write of a time when you were brave? What gave you the courage to be brave?",
            "What would you do differently or what would you like to change?",
            "Can you describe yourself in five positive words?",
            "What are you most grateful for?",
            "What helps you to smile, even if you don't feel like it?",
        };

        Random randomGenerator = new Random();
        string prompt = randomGenerator.Next(_)

        }
        return prompt;
}
