using System;

partial class Program
{

    static double FastPow(double n, int k)
    {
        if (k == 0) { return 1; }
        if ((k & 1) == 0)
        {
            double f = FastPow(n, k >> 1);
            return f*f;
        }
        else { return n * FastPow(n, k - 1); }
    }


    public static void Main(string[] args)
    {
        int k;
        double n;
        bool x = double.TryParse(Console.ReadLine(), out n);
        bool y = int.TryParse(Console.ReadLine(), out k);

        if (x && y && k >= 0)
        {
            Console.WriteLine(FastPow(n, k));
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }
    }
}