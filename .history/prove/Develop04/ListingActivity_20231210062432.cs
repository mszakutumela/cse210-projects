using System;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    }
    
    private List<string> _prompts = new() {
        "Think of a time when you stood up for someone else.",
        
    }
}