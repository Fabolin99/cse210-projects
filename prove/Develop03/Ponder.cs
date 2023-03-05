using System;

class PonderOnScriptures
{
    public void DisplayPonderActivity()
    {
        string userAnswer = "";
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        while(userAnswer != "no")
        {
            Console.WriteLine($"Hello {name}, would you like to participate in an activity?(yes/no)");
            userAnswer = Console.ReadLine();
            if(userAnswer == "yes")
            {
                Console.WriteLine("Please ponder on the following question for a couple of seconds:");
                var random = new Random();
                var list = new List<string>{"Do you often read your scriptures?",
                "Have you set spiritual goals this month?",
                "Who are people that inspire you?",
                "When have you felt the Holy Ghost this month?",
                "Who is Jesus Christ to you?"};
                int index = random.Next(list.Count);
                
                Console.WriteLine($"---{list[index]}---");
                Thread.Sleep(8000);
            }
            else if(userAnswer != "no")
            {
                Console.WriteLine("Please, select a valid option");
            }
        }
    }
}