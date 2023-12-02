class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new()
        {
            new Square(5, "Red"),
            new Rectangle(5, 6, "Yellow"),
            new Circle(5, "Blue")
        };

        foreach(Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine(area);
        }
    }
}

abstract class Shape 
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
    public void SetColor(string newColor)
    {
        _color = newColor;
    }

    public abstract double GetArea();
}

class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}

class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * Math.PI;
    }
}

class Square : Shape
{
    public double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}