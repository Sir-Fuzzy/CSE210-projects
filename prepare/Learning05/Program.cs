using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Orange",2);

        // Console.WriteLine($"{square.GetArea()}, {square.GetColor()}");

        Rectangle rectangle = new Rectangle("Green", 2,4);

        // Console.WriteLine($"{rectangle.GetArea()}, {rectangle.GetColor()}");

        Circle circle = new Circle("Pink", 1);

        // Console.WriteLine($"{circle.GetArea()}, {circle.GetColor()}");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetArea()}, {shape.GetColor()}");
        }

    }
}