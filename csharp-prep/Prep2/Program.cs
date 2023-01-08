using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string value = Console.ReadLine();
        int percentage = int.Parse(value);

        string grade = "";

        if(percentage >= 90)
        {
            grade = "A";
        }

        else if(percentage >= 80)
        {
            grade = "B";
        }
        else if(percentage >= 70)
        {
            grade = "C";
        }

        else if(percentage >= 60)
        {
            grade = "D";
        }
        else if(percentage <= 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if(percentage >= 70)
        {
            Console.WriteLine("You passed. Congrats!");
        }

        else
        {
            Console.WriteLine("You did not pass.");
        }
    }
}