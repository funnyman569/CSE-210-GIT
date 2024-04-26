using System;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("What is your grade percentage? ");
int grade_percentage = int.Parse(Console.ReadLine());
string grade = "No answer yet";
if(grade_percentage >= 90)
{  
    grade = "A";
}
else if (grade_percentage >= 80 && grade_percentage < 90)
{
    grade = "B";
}  
else if (grade_percentage >= 70 && grade_percentage < 80)
{
    grade = "C";
}
else if (grade_percentage >= 60 && grade_percentage < 70)
{
    grade = "D";
}
else
{
    grade = "F";
}

if (grade_percentage >= 70)
{
    Console.WriteLine("Congrats you passed the class");
}
else
{
    Console.WriteLine("You did not pass. Go find a smart person and hang out with them.");
}

string plus_or_minus = "";
double remainder = grade_percentage % 10;
if (remainder >= 7)
{
    plus_or_minus = "+";
}
else if (remainder < 3)
{
    plus_or_minus = "-";
}

Console.WriteLine($"Your final grade is {grade}{plus_or_minus}.");
