using System;
using System.Diagnostics.Metrics;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = 1;
        while (input != 0)
        {
            Console.WriteLine("Please input a number or '0' if you are done.");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        Console.Write("The sum is: ");
        Console.WriteLine(numbers.Sum());
        Console.Write("The average is: ");
        Console.WriteLine(numbers.Average());
        Console.Write("The largest number is: ");
        Console.WriteLine(numbers.Max());
        
    }

}