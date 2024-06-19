class Cirlce : Shape
{
    public double  _radius;
    public Cirlce(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}