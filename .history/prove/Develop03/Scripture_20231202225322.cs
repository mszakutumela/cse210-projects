using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
}

public Scripture(Reference reference, string word)
{
    _reference = reference;
    _words = words;
}

public void HideRandomWords(int numberToHide) 
{
    Random random = new();
    for (int i = 0; i < count; i++)
    {
        int index = random.Next(0, _words.Count);
        while (_words[index].Hide())
        {
            return _words[random.Next(0, _words.Count)];
        }
    }

}

public string GetDisplayText()
{

}

public bool IsCompletelyHidden()
{
    foreach (word in _words)
    {
        if (!word.Hide())
        {
            return false;
        }
        
    }
}