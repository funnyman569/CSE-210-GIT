using System.Runtime.InteropServices;

abstract class RoundShape
{
    public abstract double Area();
}

class Circle : RoundShape
{
    private double _radius;
    public Circle(double r) {_radius = r;}
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}

class Cylinder : Circle
{
    public double _height;
    public Cylinder(double r, double h) : base(r) 
    {_height = h;}
    public override double Area()
    {
        return 2.0 * base.Area() + 2.0 * Math.PI * 2.0 * _height;
    }

class Sphere : Circle
{
    public Sphere(double r) : base(r) 
    {
    }
    public override double Area()
    {
        return 4.0 * Math.PI * base.Area(); 
    }

}}
