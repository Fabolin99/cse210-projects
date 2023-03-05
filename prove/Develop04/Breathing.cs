using System;
namespace Develop04
{
    class BreathingActivity : Activity
    {
        public BreathingActivity(
            string activityName, 
            string activityDescription) : base(
            activityName, 
            activityDescription) {

        }

        public void DoBreathingActivity() 
        {
            AskAndDisplayName();
            
            int time = GetSessionDuration();
            
            Console.WriteLine("Get Ready...");
            DisplaySpinner();

            int duration = 0;

            while(duration < time)
            {
                Console.WriteLine("\n \n");
                Console.Write("Breathe in...");
                for(int trackTime = 5; trackTime != 0; trackTime -- )
                {
                    Console.Write(trackTime);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }    
                Console.WriteLine("\n \n");
                Console.Write("Breathe out...");
                for(int trackTime = 5; trackTime != 0; trackTime -- )
                {
                    Console.Write(trackTime);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }    
                duration += 10;
            }
            Console.WriteLine("\n \n");
            DisplayEndMessage();
            Console.WriteLine($"You have completed another {time} seconds of Breathing Activity");
        }
    }
}