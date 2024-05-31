using System;


public class Comment
{
    private string _commenter;
    private string _commentText;


    public Comment(string commentText, string commenter)
    {
        _commenter = commenter;
        _commentText = commentText;
    }


    public string GetComment()
    {
        return _commentText;
    }

    public string GetCommenter()
    {
        return _commenter;
    }
}