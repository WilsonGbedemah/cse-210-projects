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
        Console.Write($"{direction} ");
        
        // The longer the delay, the slower the appearance (simulates slowing breath)
        int[] delays = { 200, 300, 400, 500, 600 };  // Fast to slow

        if (direction.ToLower().Contains("out"))
            Array.Reverse(delays); // Make exhale start slow and speed up

        foreach (int delay in delays)
        {
            Console.Write(".");
            Thread.Sleep(delay);
        }
    }
}
