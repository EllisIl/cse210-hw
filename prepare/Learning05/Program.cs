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