using System;

class Reference
{
    private string _bookName;
    private string _chapterNumber;
    private string _verseNumber;

    public Reference(string bookName, string chapterName, string verseNumber)
    {
        _bookName = bookName;
        _chapterNumber = chapterName;
        _verseNumber = verseNumber;
    }
    public void displayInformation()
    {
        Console.WriteLine($"{_bookName}, {_chapterNumber}:{_verseNumber}");
    }

    
}