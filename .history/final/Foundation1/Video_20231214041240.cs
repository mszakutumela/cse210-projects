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
        _author = author;
        _length = length;
    }

    public void AddComment(Comment Comment)
    {
        _comments.Add(Comment);
    }

    public int GetNumberOfComments()
    {
        int count = 0;
        count = _comments.Count;

        return count;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"title: {_title} | Author: {_author} | Length: {_length} minutes");
        Console.Writealine();
    }
}