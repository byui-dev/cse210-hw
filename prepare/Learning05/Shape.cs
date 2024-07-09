public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;

    }

    // A default body for this method will not be defined in the base class that looks like this
    // public virtual double GetArea()
    // {
    //     return 0;
    // }
    // The function can be defined, instead as an abstracr function, meaning that it is an empty virtual
    // function that must be implemented or "filled in"  by any class that inherits from Shape. This also means that any
    // class that has an abstract method must be declared to be abstract
    public abstract double GetArea();

}