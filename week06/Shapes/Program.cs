using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        // Create a Circle object
        Circle circle = new Circle(5.0);
        circle.SetColor("Red");
        Console.WriteLine($"Circle Color: {circle.GetColor()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
        shapes.Add(circle);

        // Create a Square objects
        Square square = new Square(4.0);
        square.SetColor("Blue");
        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");
        shapes.Add(square);

        // Create Rectangle object
        Rectangle rectangle = new Rectangle(3.0, 6.0);
        rectangle.SetColor("Green");
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}