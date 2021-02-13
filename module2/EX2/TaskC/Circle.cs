using System;

public static class Circle
{
    public static double Circumference(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double Square(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double Distance(double x1, double y1, double r1, double x2, double y2, double r2)
    {
        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)) - r1 - r2;
    }
}