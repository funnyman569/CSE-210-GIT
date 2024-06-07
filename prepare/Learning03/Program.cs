using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new();
        {
            //first constructor
            int top1 = fraction.GetTop();
            int bottom1 = fraction.GetBottom();

            string fractionString1 = fraction.GetFractionString(top1, bottom1);
            System.Console.WriteLine($"{fractionString1}");
            double decimalDouble1 = fraction.GetDecimalDouble(top1,bottom1);
            System.Console.WriteLine($"{decimalDouble1}");

            //secound constructor
            fraction.SetTop(5);
            int top2 = fraction.GetTop();
            int bottom2 = fraction.GetBottom();

            string fractionString2 = fraction.GetFractionString(top2,bottom2);
            System.Console.WriteLine($"{fractionString2}");
            double decimalDouble2 = fraction.GetDecimalDouble(top2,bottom2);
            System.Console.WriteLine($"{decimalDouble2}");

            //third constructor
            fraction.SetTop(5);
            fraction.SetBottom(2);
            int top3 = fraction.GetTop();
            int bottom3 = fraction.GetBottom();

            string fractionString3 = fraction.GetFractionString(top3,bottom3);
            System.Console.WriteLine($"{fractionString3}");
            double decimalDouble3 = fraction.GetDecimalDouble(top3,bottom3);
            System.Console.WriteLine($"{decimalDouble3}");





        }
    }
}