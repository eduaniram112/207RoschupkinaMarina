using System;

public class Exponent : Function
{
    public override double GetValueInX(double x)
    {
        if (x != 0) return Math.Pow(Math.E, 1.0/x);
        else throw new ArgumentException("Function is not defined in point");
    }
}
