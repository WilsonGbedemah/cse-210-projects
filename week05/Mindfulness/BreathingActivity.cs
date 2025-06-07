using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            AnimateBreath("Breathe in");
            Console.WriteLine();
            AnimateBreath("Breathe out");
        }

        DisplayEndingMessage();
    }

private void AnimateBreath(string direction)
{
    int durationPerPhase = 4; // You can make this customizable later
    Console.WriteLine($"{direction} for {durationPerPhase} seconds");

    for (int i = 1; i <= durationPerPhase; i++)
    {
        Console.Write($"{i}");
        Thread.Sleep(1000); // 1 second delay
        Console.Write("\b \b"); // Erase previous number (optional for cleaner look)
    }
}

}
