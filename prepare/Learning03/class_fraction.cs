using System.Diagnostics;
using System.Runtime.CompilerServices;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }


    public void SetBottom(int bottom)
    {
        bool exitKey = true;
        while (exitKey == true)
        {
            if (bottom == 0)
            {   
               System.Console.WriteLine("Im sorry, you cannot divide by 0 silly goose");
            }
             else
            {
                exitKey = false;
            }
        }
        _bottom = bottom;
    }

    //Im not sure how to pass in my values or if i even need to
    public string GetFractionString(int top, int bottom)
    {
        return $"{top} / {bottom}";
    }

    public double GetDecimalDouble( int top, int bottom)
    {
        double topDouble = top;
        double bottomDouble = bottom;
        double number = topDouble / bottomDouble;
        return number;
    }




}