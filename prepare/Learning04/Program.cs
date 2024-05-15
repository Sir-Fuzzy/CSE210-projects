using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("James Smith", "School");
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("John Smith","Math","7.2","54-86");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingAssignment = new WritingAssignment("Jim Smith","Reading","Huck Finn");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingAssignemt());
    }    
}