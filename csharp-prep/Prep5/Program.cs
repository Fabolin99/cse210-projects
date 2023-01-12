using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string UserName = PromptUserName();

        int UserNumber = PromptUserFavoriteNumber();

        int UserResult = SquareNumber(UserNumber);

        Results(UserName, UserResult);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please, enter your name:");
        string Name = Console.ReadLine();
        return Name;
    }
    static int PromptUserFavoriteNumber()
    {
        Console.WriteLine("Please, enter your favorite number: ");
        int Number = int.Parse(Console.ReadLine());
        return Number;
    }
    static int SquareNumber(int number)
    {
        int Result = number * number;
        return Result;
    }
    static void Results(string Name, int Result)
    {
        Console.WriteLine($"{Name}, the square of your number is {Result}.");
        Console.WriteLine("Thank you for using the program!");
    }
}