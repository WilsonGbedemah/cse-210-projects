public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity helps you reflect on times you've shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you overcame a challenge.",
            "Think of a time when you helped someone.",
            "Think of a time when you were selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful?",
            "How did it begin?",
            "How did you feel afterwards?",
            "What did you learn?",
            "How will you remember this experience?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine("Now ponder on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        Random rand = new Random();

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider this prompt:\n--- {prompt} ---");
        ShowSpinner(3);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question}");
    }
}
