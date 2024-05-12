using System;
using System.Collections.Concurrent;

public class Word
{
    //Declaring member variables of class Word
    private string _text ;
    private bool _isHidden;

    //Declaring accepted constructor for the Word Class
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    } 
    

    
    public void Hide() //This function hides the word in question
    {
        _text = new string('_', _text.Length); //Hey look! It's magic! It replaces each letter with a _, not just a set length!
        _isHidden = true;
    }

    public void Show() //This function is kind of useless... but it fulfills requirements
    {
        _isHidden = false;
    }

    public bool IsHidden() //This function lets you know if the thing you called is hidden or not
    {
        return _isHidden;   
    }


    public string GetDisplayText() //This function just returns whatever is stored in _text
    {
        return _text;
    }
}