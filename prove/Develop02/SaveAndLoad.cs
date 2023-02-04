using System;

public class StoreInformation
{
    public string _fileName = "";

    public string _fileLoadName;

    public void saveFile(List<EntryData> display) 
    {
        Console.WriteLine("What is the name of the file?");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach(EntryData option in display)
            {
                outputFile.WriteLine($"{option._answerName},{option._date},{option._question},{option._answer},{option._answerGoal}");
                
            }
        }
    }

    public void loadFile(List<EntryData> display)
    {
        Console.WriteLine("What is the name of the file?");
        _fileLoadName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileLoadName);

        foreach (string line in lines)
        {
            EntryData entry = new EntryData();
            string[] parts = line.Split(",");

            entry._answerName = parts[0];
            entry._date = parts[1];
            entry._question = parts[2];
            entry._answer = parts[3];
            entry._answerGoal = parts [4];


            display.Add(entry);
        }
    }
}
