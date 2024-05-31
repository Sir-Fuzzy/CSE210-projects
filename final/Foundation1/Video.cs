using System;

public class Video 
{
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public void StoreComment(Comment comment)
    {
        _comments.Add(comment);
    }
}