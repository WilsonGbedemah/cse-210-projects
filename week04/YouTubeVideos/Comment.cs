public class Comment
{
    public string _author;
    public string _content;

    public Comment(string author, string content)
    {
        _author = author;
        _content = content;
    }

    public string GetCommentInfo()
    {
        return $"{_author}: {_content}";
    }
}