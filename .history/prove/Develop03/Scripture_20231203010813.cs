using System;

public class Scripture
{    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        _words = words;
    }

    public Reference GetReference()
    {
        return _reference;
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

    public string GetDisplayText()
    {
        Console.WriteLine($"{_reference}: ");
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string("_", word.GetText().Length) + " ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
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
}