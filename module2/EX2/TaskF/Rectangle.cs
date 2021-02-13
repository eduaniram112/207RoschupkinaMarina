using System;
using System.Collections.Generic;

public sealed class Rectangle : GeometryRef
{
    protected override List<Point> Points
    {
        set => points = value;
    }

    public Rectangle(List<Point> points) : base(points)
    {
        this.points = new List<Point>();
        foreach (Point p in points)
        {
            this.points.Add(p);
        }
    }
    public double AB { get => Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y)); }

    //public double BC { get => Math.Sqrt((points[1].X - points[2].X) * (points[1].X - points[2].X) + (points[1].Y - points[2].Y) * (points[1].Y - points[2].Y)); }


    public override double GetSquare()
    {
        return AB*AB;
    }

    protected override double GetPerimeter()
    {
        return 4*AB;
    }
    public override string ToString()
    {
        return "Rectangle. P = " + GetPerimeter().ToString("F2") + ". S = " + GetSquare().ToString("F2") + ".";
    }

}