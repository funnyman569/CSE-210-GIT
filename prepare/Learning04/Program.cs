using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new();
        System.Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment1 = new();
        System.Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new();
        System.Console.WriteLine(writingassignment1.GetWritingInformation());
    }
    

}