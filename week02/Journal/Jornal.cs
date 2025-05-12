using System.Text.Json;



public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(filename, jsonString);
        Console.WriteLine($"Entries saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
            Console.WriteLine($"Entries loaded from {filename}");
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }

    
}
