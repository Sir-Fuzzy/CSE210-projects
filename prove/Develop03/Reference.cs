using System;

public class Reference
{
    //Declaring inital member variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    

    //Setting up allowed constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse) //this one isn't used for my selected passage
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }



    public string GetDisplayText()//this function just turns the reference into a string
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}  :";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}  :";
        }
    }
}