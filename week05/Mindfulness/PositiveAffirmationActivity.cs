using System;
using System.Collections.Generic;

public class PositiveAffirmationsActivity : Activity
{
    private List<string> _affirmations;

    public PositiveAffirmationsActivity()
        : base("Positive Affirmations", "This activity helps you focus on positive thoughts and boost your mood.")
    {
        _affirmations = new List<string>
        {
            "You are capable of amazing things.",
            "Every day is a fresh start.",
            "You are worthy of love and respect.",
            "Your possibilities are endless.",
            "Believe in yourself and all that you are."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nFocus on these positive affirmations:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{_affirmations[index]}");
            ShowSpinner(4);  // Show spinner for 4 seconds between affirmations

            index = (index + 1) % _affirmations.Count;  // Loop through affirmations
        }

        DisplayEndingMessage();
    }
}