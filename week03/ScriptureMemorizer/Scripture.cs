public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor takes reference string and scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = Math.Min(numberToHide, _words.Count(w => !w.IsHidden()));
        int hiddenCount = 0;

        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
