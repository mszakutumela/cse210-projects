using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;
}

public Reference(string book, int chapter, int verse)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _startVerse = startVerse;
    _endVerse = endVerse;
}

public Reference(string book, int chapter, int startVerse, int endVerse)
{
    _book = book;
    _chapter = chapter;
    _startVerse = startVerse;
    _endVerse = endVerse;
}

public string GetBook()
{
    return _book;
}

public int GetChapter()
{
    return _chapter;
}

public int GetVerse()
{
    return _verse;
}

public int GetStartVerse()
{
    return _startVerse;
}

public int GetEndVerse()
{
    return _endVerse;
}

public string GetDisplayText()
{
    if (_verse == startVerse)
    {
        return $"{_book}"
    }
}