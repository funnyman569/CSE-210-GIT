using System.Timers;

class Activity
{
    protected string _exitstatement;
    protected  string _title;
    protected string _description;
    protected int _duration;

    public Activity(string title)
    {
        _title = title;
        System.Console.WriteLine("How long would you like this exercise to last?");
        _duration = int.Parse(Console.ReadLine());
        _exitstatement = "Thank you for participating";
    }

    //Makes the icon loader thingy
    public void Loader()
    {
        Console.Write("+");

        Thread.Sleep(2000);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character 
    }

    //prints the assigned value to description
    public void PrintDescritpion()
    {
        System.Console.WriteLine(_description);
    }

    //Prints the Title
    public void PrintTitle()
    {
        System.Console.WriteLine(_title);
    }

    //Counts how long the Loader has been running
    
    public void CountDuration(int duration)
    {
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);
    Thread.Sleep(3000);
    }

    //Retrieves the duration length of the Loader
    public int GetCounterDuration()
    {
        return _duration;
    }

    //Sets the duration length of the Loader
    public void SetCounterDuration(int duration)
    {
        _duration = duration;
    }
}