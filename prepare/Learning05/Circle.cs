public class Circle : Shape
{
    private double _radius;

    public Circle(string color double radius) : base (color)
    {
        _radius = radius;
    }

    // The override keyword is used here as well as it has been used with the other shapes
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}