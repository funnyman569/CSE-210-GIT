using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new();
        int number = randomGenerator.Next(1,101);
        int guess = 0;
        int counter = 0;
        Console.WriteLine("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        while (number != guess)
         {  
            if(number > guess)
            {   
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {   
                Console.WriteLine("Lower");
            }
            counter += 1;
            Console.WriteLine("Please guess another number. ");
            number = int.Parse(Console.ReadLine());
         }
         Console.WriteLine($"Congratulations, you got the number in {counter} guesses.");

    }
}