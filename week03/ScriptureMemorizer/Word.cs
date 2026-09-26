using System;
using System.Security.Cryptography.X509Certificates;

class Word

{
    private string _text;
    private bool _isHidden; 
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        //Store supplied text in _text string text = _text
        //Word is hidden equal to initial state (False)
    }  
    
    public void Hide()
    {
        _isHidden = true;
    //TODO Change words hidden state so it is hidden. _isHidden = True
    }

    public void show()
    {
        _isHidden = false;
            //TODO Change words hidden state so it is hidden. _isHidden = False
    }

    public bool IsHidden()
    {
        return _isHidden;
        //Return whether or not the word is currently hidden
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        //If word is hidden return underscores representing the word
        //If word is visible return original word

        return _text;
    }
}