using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string date, string mood, string prompt, string response)
    {
        Entry newEntry = new Entry(date, mood, prompt, response);
        _entries.Add(newEntry);
    }
    public void EditEntryByIndex(int index)
{
    if (index >= 0 && index < _entries.Count)
    {
        Console.WriteLine("Enter new mood (e.g., Happy, Okay, Sad, Angry, Tired, Grateful, Unspecified):");
        string newMood = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newMood))
        {
            _entries[index].mood = newMood;
        }

        Console.WriteLine("Enter new response text:");
        string newResponse = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newResponse))
        {
            _entries[index].entryText = newResponse;
        }

        Console.WriteLine("Entry updated successfully.");
    }
    else
    {
        Console.WriteLine("Invalid entry number.");
    }
}

public void DeleteEntryByIndex(int index)
{
    if (index >= 0 && index < _entries.Count)
    {
        _entries.RemoveAt(index);
        Console.WriteLine("Entry deleted successfully.");
    }
    else
    {
        Console.WriteLine("Invalid entry number.");
    }
}

    public void DisplayAll()
{
    if (_entries.Count == 0)
    {
        Console.WriteLine("No entries available.\n");
        return;
    }

    for (int i = 0; i < _entries.Count; i++)
    {
        Console.WriteLine($"Entry #{i + 1}");
        _entries[i].DisplayEntry();
    }

    // Friendly reminder
    if (!HasEntryForToday())
    {
        Console.WriteLine("You haven’t written today. Want to add an entry?\n");
    }

    Console.WriteLine("Do you want to edit or delete an entry?");
    Console.Write("Type E to edit, D to delete, or N for none: ");
    string action = Console.ReadLine().ToUpper();

    if (action == "E")
    {
        Console.Write("Enter the entry number to edit: ");
        if (int.TryParse(Console.ReadLine(), out int editNum))
        {
            EditEntryByIndex(editNum - 1); // Convert to 0-based index
        }
    }
    else if (action == "D")
    {
        Console.Write("Enter the entry number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int deleteNum))
        {
            DeleteEntryByIndex(deleteNum - 1); // Convert to 0-based index
        }
    }

    Console.WriteLine();
}


    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToTextFormat());
            }
        }

        Console.WriteLine($"Entries saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            int i = 0;

            while (i + 3 < lines.Length)
            {
                string date = lines[i].Substring("Date: ".Length).Trim();
                string mood = lines[i + 1].Substring("Mood: ".Length).Trim();
                string prompt = lines[i + 2].Substring("Prompt: ".Length).Trim();
                string response = lines[i + 3].Substring("Response: ".Length).Trim();

                Entry entry = new Entry(date, mood, prompt, response);
                _entries.Add(entry);

                i += 5;
            }

            Console.WriteLine($"Entries loaded from {filename}");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }

    public bool HasEntryForToday()
    {
        string today = DateTime.Now.ToShortDateString();
        return _entries.Exists(e => e.date == today);
    }

    public void SearchEntries(string keyword)
    {
        Console.WriteLine($"Searching for \"{keyword}\"...\n");
        bool found = false;

        foreach (Entry entry in _entries)
        {
            if (entry.date.Contains(keyword) || entry.mood.Contains(keyword))
            {
                entry.DisplayEntry();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found matching your search.\n");
        }
    }
}
