using System;
using System.IO.Pipelines;

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    internal Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
        
        // Set _words = new List of word objects

        //Split scripture text into individual words; will use .Split method

        //Create word object for each word; will use a foreach loop
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if(!word.IsHidden()) //if false return false; if true 
            {
                return false;
            }
        }
        //Check every word in list of words to see if they are hidden; note will use foreach loop on list of words
        return true;
    }
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach(Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }


        return result.Trim();
    }
    public void HideRandomWords(int numbertohide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();
        foreach(Word word in _words)
        {
            if(!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        numbertohide = Math.Min(numbertohide, visibleWords.Count);
        for(int i = 0; i < numbertohide; i ++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); 
        }
        //Select random words from _list
        //Make sure same word is not selected more than once during operation.
        //Hide selected words.
        //Do not attempt to hide more words than available.
    }
}