using System;

class Word
{
    private string _word;
    public Word(string word)
    {
        _word = word;
    }
    public void hideWord()
    {
        int numbLetters = _word.Count();
        _word = "";
        for(int i = 0; i < numbLetters; i++)
        {
            _word = _word + "_";
        }
    }
    public void displayWords()
    {
        Console.Write(_word + " ");
    }
}