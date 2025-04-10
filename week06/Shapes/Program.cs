using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 5.0));
        shapes.Add(new Rectangle("blue", 4.0, 6.0));
        shapes.Add(new Circle("green", 3.0));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area.ToString("F2")} units squared.");
        }
    }
}