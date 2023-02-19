using System;

class Scripture

{
List<Word> scripture = new List<Word>();

public Scripture(string scriptureWords)
{
    string[] words = scriptureWords.Split(" ");
    foreach(string word in words)
    {
        scripture.Add(new Word(word));
    }
}

    public void displayScripture()
    {
        foreach(Word word in scripture)
        {
            word.displayWords();
        }
    }
    public void hideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(scripture.Count);
        Word randomWord = scripture[index];
        randomWord.hideWord();
    }
}