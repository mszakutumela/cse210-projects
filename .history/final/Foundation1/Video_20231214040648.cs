using System;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments = new();

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author
    }

    public void AddComment(Comment Comment)
    {

    }

    public int GetNumberOfComments()
    {

    }

    public void DisplayDetails()
    {

    }
}