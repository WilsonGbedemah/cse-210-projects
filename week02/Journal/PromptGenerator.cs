public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What was the strongest emotion I felt today?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What was the most challenging part of your day?",
        "How did I see the hand of the Lord in my life today?",
        "What are your goals for tomorrow?",
        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}