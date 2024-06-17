using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

class Breathing : Activity
{
    public Breathing() : base("Breathing Acivity")
    {
        string title = _title;
        _description = "In this activity, you will be breathing in and out";
        System.Console.WriteLine("How long do you want the Activity to last? ");
    }

    //Returns breathe in or out alternating every 3 secounds until the time set by the user is reached
    public void BreatheInAndOut()
    {
        System.Console.WriteLine($"Welcome to the {_title}! {_description}");
        //duration variables
        int durationInMiliSec = _duration * 1000;

        //stopwatch intialization
        Stopwatch stopwatch = new();
        stopwatch.Start();

        //while loop variables
        int intCounter = 0;
        bool switchPrompt = true;

        //while statement
        while (durationInMiliSec >= intCounter)
        {
            //formatting for stopwatch to intiger for comparison
            intCounter = (int)stopwatch.ElapsedMilliseconds;
            
            
            if (switchPrompt)
            {
                switchPrompt = false;
                Console.WriteLine("Breathe In");
                Loader();
            }
            else
            {
                switchPrompt = true;
                System.Console.WriteLine("Breathe Out");
                Loader();
            }
        }
        System.Console.WriteLine(_exitstatement);
    }
}