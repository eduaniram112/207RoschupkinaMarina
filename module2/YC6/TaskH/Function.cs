using System;

public abstract class Function
{
    public static Function GetFunction(string functionName)
    {
        if (functionName == "Sin") return new Sin();
        else if (functionName == "Exp") return new Exponent();
        else if (functionName == "Parabola") return new Parabola();
        else throw new ArgumentException("Incorrect input");
    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        double res = 0;
        if (left <= right)
        {
            double i_copy = left;
            for (double i = left; i<right-step; i+=step)
            {
                i_copy += step;
                res += step*(func.GetValueInX(i) + func.GetValueInX(i+step))/2;
            }
            if (i_copy < right)
            {
                res += (right - i_copy) * (func.GetValueInX(i_copy) + func.GetValueInX(right)) / 2;
            }
            if (i_copy > right)
            {
                res += (i_copy - right) * (func.GetValueInX(i_copy) + func.GetValueInX(right)) / 2;
            }
        }
      
        else throw new ArgumentException("Left border greater than right");
        return res;
    }
}
