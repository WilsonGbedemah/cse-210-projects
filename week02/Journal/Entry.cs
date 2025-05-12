using System.Text.Json.Serialization;

public class Entry
{
    [JsonPropertyName("date")]
    public string _date { get; set; } = "";

    [JsonPropertyName("prompt")]
    public string _promptText { get; set; } = "";

    [JsonPropertyName("response")]
    public string _entryText { get; set; } = "";

    public Entry() {}

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}