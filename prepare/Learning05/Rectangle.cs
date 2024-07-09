public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // The use of the override keyword has to be noted here
    public override double GetArea()
    {
        return _length * _width;
    }
}