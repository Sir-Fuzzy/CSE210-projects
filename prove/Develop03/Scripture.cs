using System;
using System.Collections.Concurrent;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;



    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wholeThing = text.Split(' ');
        foreach(var oneWord in wholeThing)
        {
            Word wordObject = new Word(oneWord);
            _words.Add(wordObject);
        }
    }



    public void HideRandomWords(int numberToHide)
    {
        
        for (int i = 0; i < numberToHide; i++)
        {
            var random = new Random();
            int index = random.Next(_words.Count);
            Word word = _words[index];
            if (word.IsHidden()== false)
            {
                word.Hide();
            }
            else
            {
                i--;
            }
        }
    }


    public string GetDisplayText()
    {
        string completeText = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words)
        {
            completeText = completeText + " " + word.GetDisplayText();
        }
        return completeText;
    }



    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}