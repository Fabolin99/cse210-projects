using System;
namespace Develop04
{
    class ListingActivity : Activity
    {
        public ListingActivity(string activityName, 
            string activityDescription) : 
            base(activityName, activityDescription) 
        {  
        }
        public void DoListingActivity()
        {
            AskAndDisplayName();
            int time = GetSessionDuration();
            Console.WriteLine("Get Ready...");
            DisplaySpinner();

            var random = new Random();
            var list = new List<string>{"Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
            int index = random.Next(list.Count);

            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"---{list[index]}---");

            Console.Write("You may begin in...");
                for(int trackTime = 5; trackTime != 0; trackTime -- )
                {
                    Console.Write(trackTime);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                } 
            Console.WriteLine("\n \n");

            int duration = 0;
            int count = 0;

            while(duration < time)
            {
                for(int trackTime = 5; trackTime != 0; trackTime -- )
                {
                    Console.Write(">");
                    Console.ReadLine();
                    count += 1;
                } 
                duration += 10;   
            }
            Console.WriteLine($"You have listed {count} answers");

            
            Console.WriteLine("\n \n");
            DisplayEndMessage();
            Console.WriteLine($"You have completed another {time} seconds of Listing Activity");  
        }
    }
}