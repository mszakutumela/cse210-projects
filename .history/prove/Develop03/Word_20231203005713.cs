using System;

public class Word 
{
    private string _text;
    private bool _isHidden;
}

{
    _text = text;
    _isHidden = false;
}

public void Hide()
{
    _isHidden = true;
}public Word(string text)


public void Show()
{

}

public bool IsHidden()
{
    return _isHidden;
}

public string GetText()
{
    return _text;
}

public string GetDisplayText()
{

}