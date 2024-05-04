using System;

class Program
{
    static void Main(string[] args)
    {
        DispalyWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square_number = SquareNumber(number);
        DisplayResult(square_number, name);

        static void DispalyWelcome()
            {  
                Console.WriteLine("Welcome to the program. ");
            }
            static string PromptUserName()
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                return name;
            }
            static int PromptUserNumber()
            {
                Console.WriteLine("Give me a number, any number: ");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
            static int SquareNumber(int number)
            {
                int square_number = number * number;
                return square_number;
            }
            static void DisplayResult(int number, string name)
            {
                Console.WriteLine($"{name}, {number}" );
                
            }
    }
}