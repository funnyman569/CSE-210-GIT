using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Listing : Activity
{
    private string[] _Prompts; 
    
     public Listing() : base("The Listing Activity")
    {
        _Prompts = new string[] 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
    }

    public string GetRandomPrompt()
    {
        Random random = new();
        int countOfPrompts = _Prompts.Count();
        int randomNumber = random.Next(countOfPrompts);
        string randomString = _Prompts[randomNumber];
        return randomString;
    }

    public void ListingExercise()
    {
        System.Console.WriteLine($"Welcome to the {_title}! {_description}");

        string randomString =  GetRandomPrompt();
        System.Console.WriteLine(randomString);
        Thread.Sleep(2000);
        System.Console.WriteLine("Please take 10 secounds to think about your response");
        Loader();
        Thread.Sleep(10000);
       
        //duration variables
        int durationInMiliSec = _duration * 1000;

        //stopwatch intialization
        Stopwatch stopwatch = new();
        stopwatch.Start();

        //while loop variables
        int timeCounter = 0;
        int inputCounter = 0;

        //while statement
        System.Console.WriteLine("Begin Writing");
        while (durationInMiliSec >= timeCounter)
        {
            timeCounter = (int)stopwatch.ElapsedMilliseconds;
            Console.ReadLine();
            inputCounter += 1;
            System.Console.WriteLine("Keep Writing!");
        }

        System.Console.WriteLine($"Good job! You wrote {inputCounter} things!");

        System.Console.WriteLine(_exitstatement);
    }

}