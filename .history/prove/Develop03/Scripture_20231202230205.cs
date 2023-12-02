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
    for (int i = 0; i < numberToHide; i++)
    {
        int index = random.Next(0, _words.numberToHide);
        while (_words[index].Hide())
        {
            return _words[random.Next(0, _words.numberToHide)];
        }
    }

}

public string GetDisplayText()
{
    Console.WriteLine(_reference);
    foreach (Word _word in words)
    {
        string 
    } 
}   

public bool IsCompletelyHidden()
{
    foreach (word in _words)
    {
        if (!word.Hide())
        {
            return false;
        }
        return true;
    }
}