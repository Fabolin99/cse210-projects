using System;

class Program
{
    static void Main(string[] args)
    {
        //Solution to problem 1
       /*Console.WriteLine("Enter a random number:");
       string number = Console.ReadLine();
       int numberValue = int.Parse(number);*/

       Random randomGenerator = new Random();
       int magic = randomGenerator.Next(1,101);
        
        int guess = -1;
        int countGuess = 0;
        
    while(magic != guess)
        {
           Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            countGuess ++; 
                
            if(guess < magic )
            {
            Console.WriteLine("Guess higher");
            }
            else if(guess == magic)
            {
            Console.WriteLine("You're right!");
            }
            else 
            {
            Console.WriteLine("Guess lower");
            }
        }
        Console.WriteLine($"Your attempts: {countGuess}");
    }
}