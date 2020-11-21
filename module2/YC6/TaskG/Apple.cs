using System;
using System.Linq;

public class Apple : IComparable<Apple>
{
    private double weight;
    private string color;

    public double Weight
    {
        get {
            return weight;
        }
        set {
            if (value <= 1000 && value > 0) weight = value;
            else throw new ArgumentException("Incorrect input");
        }
    }

    public string Color
    {
        get {
            return color;
        }
        set {
            if (value.ToString().Length<=5 && char.IsUpper(value[0])) color = value.ToString();
            else throw new ArgumentException("Incorrect input");
        }
    }


    public int CompareTo(Apple p)
    {
        return this.Weight.CompareTo(p.Weight);
    }

    public override string ToString()
    {
        return Color + " Apple. Weight = " + Weight.ToString("F2") + "g.";
    }
}