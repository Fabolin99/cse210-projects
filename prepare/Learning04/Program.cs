using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment studentInfo1 = new Assignment("Daniel Santana", "European History");
        Console.WriteLine(studentInfo1.GetSummary());

        MathAssignment studentInfo2 = new MathAssignment("Fabian Diaz Santiago", "Fractions", "7.3", "8-19");
        Console.WriteLine(studentInfo2.GetHomeworkList());

        WritingAssignment studentInfo3 = new WritingAssignment("Claudia Victorino", "Assignment 3","The Causes of World War II");
        Console.WriteLine(studentInfo3.GetSummary());
        Console.WriteLine(studentInfo3.GetWritingInformation());


        
    }
}