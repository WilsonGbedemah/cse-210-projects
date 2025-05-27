using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
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