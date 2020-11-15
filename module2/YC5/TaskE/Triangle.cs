using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AC + BC + AB;
    }

    public double GetSquare()
    {
        double p = GetPerimeter()/ 2;
        return Math.Sqrt(p * (p - AC) * (p - AB) * (p - BC));
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        double a = 0, b = 0;
        angle = 0;
        if (AC == BC) { a = AC; b = AB; }
        else if (AC == AB) { a = AC; b = BC; }
        else if (AB == BC) { a = AB; b = AC; }

        if (a != 0)
        {
            double cos = (a * a + a * a - b * b) / (2 * a * a);
            angle = Math.Acos(cos);
            return true;
        }
        else return false;
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        hypotenuse = Longest();
        if (Math.Abs(AC * AC + BC * BC + AB * AB - 2 * Longest() * Longest()) < Math.Pow(10,-8))
        {
            return true;
        }
        else return false;
     
    }

    
    private static double GetLengthOfSide(Point first, Point second)
    {
        double X = Math.Pow(Math.Abs(first.GetX() - second.GetX()), 2);
        double Y = Math.Pow(Math.Abs(first.GetY() - second.GetY()), 2);
        return Math.Sqrt(X+Y);
    }

    private double Longest()
    {
        if (AC > AB && AC > BC) return AC;
        if (AB > AC && AB > BC) return AB;
        else return BC;

    }
}