using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.", 
    };

    private List<string> _promptsQues = new() {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?"
    }

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }
}