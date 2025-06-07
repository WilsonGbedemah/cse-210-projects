using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> _prompts;

    public GratitudeActivity() 
        : base("Gratitude", "This activity helps you reflect on what you're grateful for to improve mood and awareness.")
    {
        _prompts = new List<string>
        {
            "What made you smile today?",
            "Who is someone you're thankful for?",
            "What is a little thing that made your day better?",
            "What ability or talent are you grateful to have?",
            "What is something around you that you appreciate right now?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nReflect on this prompt:\n-- {prompt} --");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> responses = GetGratitudeResponses();
        Console.WriteLine($"You shared {responses.Count} thoughts of gratitude.");
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetGratitudeResponses()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            items.Add(input);
        }

        return items;
    }
}
