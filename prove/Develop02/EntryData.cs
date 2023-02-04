using System;

public class EntryData

{
    public string _question;

    public string _date;

    public string _answer;

    public string _answerName;

    public string _answerGoal;

    public void writeAnswer()
    {
        Console.WriteLine("Enter your name:");
        _answerName = Console.ReadLine();

        var random = new Random();
        var list = new List<string>{"Did I help someone today?",
        "How did I show my love to others?","What was the most meaningful experience today?",
        "Did I have time to ponder today's experiences?", "Do I consider today a good day?"};
        int index = random.Next(list.Count);
        _question = (list[index]);
        Console.WriteLine(_question);
        _answer = Console.ReadLine();

        Console.WriteLine("Please, write a goal for this week:");
        _answerGoal = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

}   