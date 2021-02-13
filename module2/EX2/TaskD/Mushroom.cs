using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; }
    private double Weight { get; }
    private double Diameter { get; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        if (weight <= 0) throw new ArgumentException("Incorrect input");
        Weight = weight;
        if (diameter <= 0) throw new ArgumentException("Incorrect input");
        Diameter = diameter;

    }

    public static Mushroom Parse(string line)
    {
        string[] str = line.Split();
        if (str.Length!=3) throw new ArgumentException("Incorrect input");
        double w, d;
        if (!double.TryParse(str[1], out w) || !double.TryParse(str[2], out d)) throw new ArgumentException("Incorrect input");
        return new Mushroom(str[0], w, d);
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        int count = 0;
        double diam=0.0;
        foreach (Mushroom grib in mushrooms)
        {
            if (grib.Weight > m)
            {
                count++;
                diam += grib.Diameter;
            }
        }
        if (count == 0) return 0;
        else return diam / count;
    }
}