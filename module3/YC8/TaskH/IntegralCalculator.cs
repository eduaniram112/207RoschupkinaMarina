using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegralCalculator
{
    public static void InsertParameter(int param)
    {
        if (param == 0) Program.func = Sin;
        else if (param == 1) Program.func = Cos;
        else Program.func = Tan;
    }

    public static double Sin(double a,double b)
    {
        double integral = 0;
        for(double i = a; i < b; i += Program.EPSYLON)
        {
            integral += Program.EPSYLON * (Math.Sin(i) + Math.Sin(i + Program.EPSYLON))/2;
        }
        return integral;
    }

    public static double Cos(double a, double b)
    {
        double integral = 0;
        for (double i = a; i < b; i += Program.EPSYLON)
        {
            integral += Program.EPSYLON * (Math.Cos(i) + Math.Cos(i + Program.EPSYLON))/2;
        }
        return integral;
    }

    public static double Tan(double a, double b)
    {
        double integral = 0;
        for (double i = a; i < b; i += Program.EPSYLON)
        {
            integral += Program.EPSYLON * (Math.Tan(i) + Math.Tan(i + Program.EPSYLON))/2;
        }
        return integral;
    }

}

