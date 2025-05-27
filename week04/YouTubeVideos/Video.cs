using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void SetLengthInSeconds(int lengthInSeconds)
    {
        if (lengthInSeconds < 0)
        {
            throw new ArgumentException("Length cannot be negative.");
        }
        _lengthInSeconds = lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;

    }
    
    public string GetVideoInfo()
    {
        return $"{_title} by {_author}, Length: {FormatLength(_lengthInSeconds)}";
    }

    private string FormatLength(int seconds)
    {
        int minutes = seconds / 60;
        seconds %= 60;
        return $"{minutes:D2}:{seconds:D2}";
    }
}