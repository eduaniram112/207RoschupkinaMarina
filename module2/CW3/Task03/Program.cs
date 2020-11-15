using System;
class MyFunction
{
    double xmi, xma;
    public MyFunction(double mi, double ma)
    {
        xmi = mi; xma = ma;
    }
    public double this[double x]
    {
        get
        {
            if (x < xmi || x > xma)
            {
                return 0;
            }
            else return Math.Sin(x);
        }
    }
}
class Program
{
    static void Main()
    {
        double rmi = 0, rma = Math.PI;
        MyFunction sin = new MyFunction(0, Math.PI);
        double s = 0, del = Math.PI/6;
        for (double x = rmi; x < rma; x += del)
            Console.WriteLine(sin[x]);

    }
}
