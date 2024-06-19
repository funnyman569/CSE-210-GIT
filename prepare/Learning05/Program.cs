using System;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
       shapes.Add(new Square("Green", 4));
       shapes.Add(new Rectanglez("blue",3,3));
       shapes.Add(new Cirlce("Green", 3));

       foreach(Shape shape in shapes)
       {
        string color = shape.getColor();
        double area = shape.GetArea();

        System.Console.WriteLine($"The color of the shape is {color} \n The area of the shape is{area}");

       }


    }
}