using System;
namespace Develop04
{
    class NotesActivity: Activity
    {
        public NotesActivity(string activityName, 
            string activityDescription) : 
            base(activityName, activityDescription) 
        {  
        }
        
        public void DoNotesActivity()
        {
            string userAnswerNotes = "";
            AskAndDisplayName();
            Console.WriteLine("Get ready...");
            DisplaySpinner();
            

            Console.WriteLine("Please, write any impression that you want to record on your notes (type 'quit' to finish)");
            while(userAnswerNotes != "quit")
            {
                Console.Write(">");
                userAnswerNotes = Console.ReadLine();
            }
 
            Console.WriteLine("\n \n");
            DisplayEndMessage();
            Console.WriteLine($"You have completed the Notes Activity");  

        }
    }
}