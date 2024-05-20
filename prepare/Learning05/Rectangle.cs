using System.Drawing;

class Rectangle(double length, double width, string color) : Shape(color)
{
    private double _length = length;
    private double _width = width;


    public override double GetArea()
    {
        return _length * _width;
    }
}