using System;

public class Fraction
{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int wholeNumnber)
    {

        _top = wholeNumnber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {

        _top = top;
        _bottom = bottom;
    }
    
    public string GetFractionString()
    {

        // This has not been stored as a member variable,
        // but as a temporary, local variable that will be recomputed each time this is called
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {

        // This is not stored as a member variable,
        // as it will be recomputed eadh time this is called.
        return (double)_top / (double)_bottom;
    }
}        



