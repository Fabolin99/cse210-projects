using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        PonderOnScriptures ponder = new PonderOnScriptures();
        ponder.DisplayPonderActivity();
        Reference information = new Reference("1 Corinthians", "13", "4");
        information.displayInformation();
        Scripture bible = new Scripture("Charity suffereth long, and is kind; charity envieth not; charity vaunteth not itself, is not puffed up"); 

        while(answer != "quit")
        {
            bible.displayScripture();
            answer = Console.ReadLine();
            bible.hideRandomWord();
            Console.Clear();
            Console.WriteLine("Please press enter to hide words or type 'quit' to finish");
            Console.WriteLine();
        }
        
        

    }
}