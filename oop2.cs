using System;
using System.Collections.Generic;

class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius;

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle { Radius = 2 });
        shapes.Add(new Rectangle { Width = 5, Height = 4 });

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetType().Name);
            Console.WriteLine(s.CalculateArea());
        }
    }
}
