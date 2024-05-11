using System;
using System.Data;
using System.Runtime.InteropServices;



class Program()
{
    static void Main(string[] args)
    { 
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._endYear = "2024";
        job1._startYear = "2000";

        Job job2 = new();
        job2._company = "Bing";
        job2._jobTitle = "Software Engineer";
        job2._endYear = "2000";
        job2._startYear = "1980";

        Resume myResuem = new();
        myResuem._name = "Alex";
        myResuem._jobs.Add(job1);
        myResuem._jobs.Add(job2);

        myResuem.Display();
            
        
    }
}





