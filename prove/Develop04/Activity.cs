using System;
namespace Develop04
{
    class Activity
    {
        private string _activityName = "";
        private string _activityDescription = "";
        
        public Activity(string activityName, string activityDescription)
        {
            _activityName = activityName;
            _activityDescription = activityDescription;
        }

        public int GetSessionDuration() 
        {
            Console.WriteLine("How long, in seconds, would you like for your session?");
            string value = Console.ReadLine();
            int userTime = int.Parse(value);
            return userTime;
        }

        public string GetActivityName()
        {
            return _activityName;
        }

        public string GetActivityDescription()
        {
            return _activityDescription;
        }
        
        public string GetWelcomeMessage()
        {
            return $"Welcome to the {_activityName}. \n \n{_activityDescription}"; 
        }

        public void DisplaySpinner()
        {
            List<string> animationSymbols = new List<string>();
            animationSymbols.Add("|");
            animationSymbols.Add("/");
            animationSymbols.Add("-");
            animationSymbols.Add("\\");
            animationSymbols.Add("|");
            animationSymbols.Add("/");
            animationSymbols.Add("-");              
            animationSymbols.Add("\\");

            foreach(string s in animationSymbols)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        }
        public void DisplayEndMessage()
        {
            Console.WriteLine("Well Done!");
            DisplaySpinner();
        }

        public void AskAndDisplayName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine($"Hi, {name}");

        }
    }
}