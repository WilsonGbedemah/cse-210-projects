public class Comment
{
    private string _author;
    private string _content;

    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _content = content;
    }

    public string GetCommentInfo()
    {
        return $"{_author}: {_content}";
    }
}