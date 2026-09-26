using System;

class ScriptureReference

{
    private string _book {get; set;}
    private int _chapter {get; set;}
    private int _startingVerse {get; set;}
    private int _endVerse {get; set;}

    
//constructor for single verse
    public ScriptureReference(string book, int chapter, int startingVerse)
    {
        _book= book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endVerse = startingVerse;

    }

//constructor for multiple verses (range)
public ScriptureReference(string book, int chapter, int startingVerse, int endVerse)
    {
        _book= book;
        _chapter = chapter;
        _startingVerse = startingVerse;
        _endVerse = endVerse;
    }



    public string GetDisplayText()
    {
        if (_startingVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startingVerse}";
        }
        return $"{_book} {_chapter}: {_startingVerse}-{_endVerse}";
    }
}