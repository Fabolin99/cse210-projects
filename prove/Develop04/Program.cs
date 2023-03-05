using System;

namespace Develop04
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "";

    
            Console.WriteLine("Welcome to the program");

        while(userAnswer != "4")
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("");
                Console.WriteLine(" 0. Start notes \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
                Console.WriteLine("");
                Console.WriteLine("Select a choice from the menu:");
                userAnswer = Console.ReadLine();

                 if (userAnswer == "0")
                {
                    NotesActivity act0 = new NotesActivity("Notes Activity",
                    "This activity will help you relax by helping you to record any impression or thoughts.");
                    Console.WriteLine(act0.GetWelcomeMessage());
                    Console.WriteLine("");
                    act0.DoNotesActivity();
                }

                if (userAnswer == "1")
                {
                    BreathingActivity act1 = new BreathingActivity("Breathing Activity",
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                    Console.WriteLine(act1.GetWelcomeMessage());
                    Console.WriteLine("");
                    act1.DoBreathingActivity();
                }

                else if(userAnswer == "2")
                {
                    ReflectingActivity act2 = new ReflectingActivity("Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how ou can use it in other aspects of your life");
                    Console.WriteLine(act2.GetWelcomeMessage());
                    act2.DisplayPrompt();
                }

                else if(userAnswer == "3")
                {
                    ListingActivity act3 = new ListingActivity("Listing Activity", 
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
                    Console.WriteLine(act3.GetWelcomeMessage());
                    act3.DoListingActivity();
                }

                else if(userAnswer != "4")
                {
                    Console.WriteLine("Please, select a valid option");
                }
            }
        }
    }
}
