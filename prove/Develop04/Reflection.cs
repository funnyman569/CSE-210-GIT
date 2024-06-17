using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Reflection : Activity
{
    private string[] _Prompts; 
    private string[] _Questions;

    public Reflection() : base("Reflection Activity")
    {
        _Prompts = new string[] {"Think of a time when you went out of your way to help someone", "Think of a time when someone helped you", "Think of a moment in life when God showed His love for you."};

        _Questions = new string [] {"Why was this experience meaningful", "How can this experience help someone else?", "What attribute do you want to further emulate?"};

        _description = "In this activity, you will spend time reflecting on positive moments in your life. You will then be asked extestential application questions about these experieces to help you to idenitfy how you can progress.";

    }
    public string GetRandomPrompt()
    {
        Random random = new();
        int countOfPrompts = _Prompts.Count();
        int randomNumber = random.Next(countOfPrompts);
        string randomString = _Prompts[randomNumber];
        return randomString;
    }

    public string GetRandomQuestion()
    {
        Random random = new();
        int countOfQuestions = _Questions.Count();
        int randomNumber = random.Next(countOfQuestions);
        string randomString = _Questions[randomNumber];
        return randomString;
    }

    public void ReflectionActivity()
    {
        System.Console.WriteLine($"Welcome to the {_title}! {_description}");

        string randomPrompt = GetRandomPrompt();

        System.Console.WriteLine("Please reflect on this question");
        System.Console.WriteLine(randomPrompt);
        Thread.Sleep(5000);
        int durationInMiliSec = _duration * 1000;

        //stopwatch intialization
        Stopwatch stopwatch = new();
        stopwatch.Start();

        //while loop variables
        int counter = 0;

        //while statement
        while (durationInMiliSec >= counter)
        {
            counter = (int)stopwatch.ElapsedMilliseconds;
            System.Console.WriteLine(GetRandomQuestion());
            Loader();
            Thread.Sleep(5000);
        }

        System.Console.WriteLine(_exitstatement);
        


    }

}

