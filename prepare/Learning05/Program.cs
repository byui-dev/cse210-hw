using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // A list for shape objects has been created, which allows any shape to be put inside it
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red, 3");
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape in shapes)
        {
            // The GetColor method from the base class is called by each shape
            string color = s1.GetColor();

            // All shapes have a GetArea method but there behavior is different for each shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shapes has an area of {area}.");
            
        }
    }
}