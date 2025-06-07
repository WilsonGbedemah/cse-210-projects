using System;
using System.Collections.Generic;
using System.Threading;

public class GoalSettingActivity : Activity
{
    public GoalSettingActivity() 
        : base("Goal Setting", "This activity helps you focus by setting a meaningful short-term goal.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nThink about something you want to accomplish today or this week...");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine("\nWhat is one specific, meaningful goal you want to achieve?");
        Console.Write("> ");
        string goal = Console.ReadLine();

        Console.WriteLine($"\nGreat! You’ve set the following goal:\n--- \"{goal}\" ---");
        ShowSpinner(3);
        Console.WriteLine("Keep this goal in mind and take a step toward it today.");

        DisplayEndingMessage();
    }
}
