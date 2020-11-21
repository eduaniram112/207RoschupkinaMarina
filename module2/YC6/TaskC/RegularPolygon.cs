using System;

public class RegularPolygon : Polygon
{
    int n;
    double a;
    public RegularPolygon(double side, int numberOfSides)
    {
        if (side<=0) throw new ArgumentException("Side length value should be greater than zero.");
        if (numberOfSides < 3) throw new ArgumentException("Number of sides value should be greater than 3.");

        n = numberOfSides;
        a = side;
    }

    public override double Perimeter => n*a;

    public override double Area => n * a * a / 4 / Math.Tan(Math.PI /n);

    public override string ToString()
    {
         return $"side: {a}; numberOfSides: {n}; area: {Area:f3}; perimeter: {Perimeter:f3}";
        
    }

}