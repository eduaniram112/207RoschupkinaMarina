using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get => points;
        set => points=value;
    }

    protected GeometryRef(List<Point> points)
    {
        this.points = new List<Point>();
        foreach( Point p in points)
        {
            this.points.Add(p);
        }
    }

    protected virtual double GetPerimeter()
    {
        return 0;
    }

    public virtual double GetSquare()
    {
        return 0;
    }

    public static GeometryRef Parse(string line)
    {
        string[] str = line.Split();
        if (str.Length%2==0) throw new ArgumentException("Incorrect input");

        List<Point> newpoints = new List<Point>();
       
        for (int i = 1; i < str.Length-1; i+=2)
        {
            double x = 0, y = 0;
            if (!double.TryParse(str[i], out x) || !double.TryParse(str[i+1], out y))throw new ArgumentException("Incorrect input");
            newpoints.Add(new Point(x, y));
        }
        if (str[0] == "Triangle" && newpoints.Count == 3) return new Triangle(newpoints);
        if (str[0] == "Rectangle" && newpoints.Count == 4) return new Rectangle(newpoints);
        if (str[0] == "GeometryRef") return new GeometryRef(newpoints);

        else throw new ArgumentException("Incorrect input");

    }
    public override string ToString()
    {
        return "GeometryRef. P = " + GetPerimeter().ToString("F2") + ". S = " + GetSquare().ToString("F2") + ".";
    }
}