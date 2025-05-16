using System;

public class Entry
{
    public string date;
    public string mood;
    public string promptText;
    public string entryText;

    public Entry() {}

    public Entry(string _date, string _mood, string _prompt, string _entry)
    {
        date = _date;
        mood = _mood;
        promptText = _prompt;
        entryText = _entry;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Mood: {mood}");
        Console.WriteLine($"Prompt: {promptText}");
        Console.WriteLine($"Response: {entryText}");
        Console.WriteLine(new string('-', 60));
    }

    public string ToTextFormat()
    {
        return $"Date: {date}\nMood: {mood}\nPrompt: {promptText}\nResponse: {entryText}\n------------------------------------------------------------";
    }
}
