using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("Red", 4);
        Shape rectangle = new Rectangle("Blue", 5, 10);
        Shape circle = new Circle("Green", 3);
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}