using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program. This program allows to record thoughts and ideas to improve your daily life");

        List<EntryData> display = new List<EntryData>();

        int answer = -1;

        while(answer != 0)
        {  
            Console.WriteLine("What do you want to do? \n\n1. Create \n2. Display \n3. Load \n4 Save \n0. Quit");
            answer = int.Parse(Console.ReadLine());

            if(answer == 1)
            {
                EntryData entry = new EntryData();
                entry.writeAnswer();
                display.Add(entry);
            }

            else if(answer == 2)
            {
                foreach(EntryData option in display)
                {
                    Console.WriteLine($"Hi, {option._answerName}, {option._date}-- {option._question}:{option._answer}.");
                    Console.WriteLine($"Your goal is: {option._answerGoal}");
                }
            }
            else if(answer == 3)
            {
                StoreInformation store = new StoreInformation();
                store.loadFile(display);
            }

            else if(answer == 4)
            {
                StoreInformation store = new StoreInformation();
                store.saveFile(display);
            }

            else if(answer == 0)
            {
                Console.WriteLine("Thank you for using the journal!");
                break;
            }

            else
            {
                Console.WriteLine("Please, enter a valid option"); 
            }
        }
    }
}