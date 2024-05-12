using System;
using System.Collections.Concurrent;

public class Scripture
{
    //Declaring the _memberVariables
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    //Defining allowed constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wholeThing = text.Split(' ');
        //This part makes breaks the string up into a list of Word objects
        foreach(var oneWord in wholeThing)
        {
            Word wordObject = new Word(oneWord);
            _words.Add(wordObject);
        }
    }



    public void HideRandomWords() //This function randomly selects some words from the list and hides them
    {
        Random random = new Random();
        //This is pretty cool! I learned about Lambda functions in C# from my brother, and he helped me set this up
        //to where it orders the words randomly, and then takes the top two and (will) hide them, but only if they aren't already hidden
        List<Word> randomWords = _words.Where(x => !x.IsHidden()).OrderBy(x => random.Next()).Take(2).ToList();

        foreach (Word word in randomWords)
        {
            word.Hide();
        }
    }


    public string GetDisplayText() //this function just makes the string to display the full scripture text
    {
        string completeText = $"{_reference.GetDisplayText()} ";
        foreach(Word word in _words)
        {
            completeText = completeText + " " + word.GetDisplayText();
        }
        return completeText;
    }



    public bool IsCompletelyHidden() //This function just checks if the whole scripture is hidden or not.
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