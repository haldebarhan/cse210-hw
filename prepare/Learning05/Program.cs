using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];

        Square square = new("Red", 4);
        Rectangle rectangle = new(4, 3, "Green");
        Circle circle = new("Blue", 4.3);
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}