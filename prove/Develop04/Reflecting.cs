using System;
namespace Develop04
{
    class ReflectingActivity : Activity
    {
        public ReflectingActivity(string activityName, 
            string activityDescription) : 
            base(activityName, activityDescription)
        {
        }
            public void DisplayPrompt()
            {
                AskAndDisplayName();
                int time = GetSessionDuration();
                Console.WriteLine("Get Ready...");
                DisplaySpinner();

                var randomPrompt = new Random();
                var list = new List<string>{"Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless.",
                "Think of a time when you felt the spirit"};
                int index = randomPrompt.Next(list.Count);

                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine($"---{list[index]}---");

                Console.WriteLine("When you are ready, press enter");
                Console.ReadLine();
                Console.Write("You may begin in...");
                
                for(int trackTime = 5; trackTime != 0; trackTime -- )
                {
                    Console.Write(trackTime);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                } 
                Console.WriteLine("\n \n");
                
                var randomQuestion = new Random();
                var listQuestion = new List<string>{"Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"};
                int i = randomQuestion.Next(listQuestion.Count);

                Console.WriteLine(listQuestion[i]);

                Console.WriteLine("\n \n");
                DisplayEndMessage();
                Console.WriteLine($"You have completed another {time} seconds of Reflecting Activity");
            }
    }
}