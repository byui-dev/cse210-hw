public class Square : Shape
{
    private double_side;

    public Square(string color, double side) : base(color)
    {
        _side = side;

    }

    // The override keyword is being used here
    public override double GetArea()
    {
        return _side * _side;
    }
}
