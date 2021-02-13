using System;
using System.Collections.Generic;

public sealed class Triangle : GeometryRef
{
    protected override List<Point> Points
    {
        set => points = value;
    }

    public Triangle(List<Point> points) : base(points)
    {
        this.points = new List<Point>();
        foreach (Point p in points)
        {
            this.points.Add(p);
        }
    }
    public double AB { get => Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y)* (points[0].Y - points[1].Y)); }
    public double AC { get => Math.Sqrt((points[0].X - points[2].X) * (points[0].X - points[2].X) + (points[0].Y - points[2].Y) * (points[0].Y - points[2].Y)); }
    public double CB { get => Math.Sqrt((points[2].X - points[1].X) * (points[2].X - points[1].X) + (points[2].Y - points[1].Y) * (points[2].Y - points[1].Y)); }

    public override double GetSquare()
    {
        double p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - AC) * (p - AB) * (p - CB));
    }

    protected override double GetPerimeter()
    {
        return AB + AC + CB;
    }

    public override string ToString()
    {
        return
            //AB + " " + AC + " " + CB;
            "Triangle. P = " + GetPerimeter().ToString("F2") + ". S = " + GetSquare().ToString("F2") + ".";
    }


}