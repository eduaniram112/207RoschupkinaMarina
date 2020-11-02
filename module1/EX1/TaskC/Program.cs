using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double x;
        bool y = double.TryParse(Console.ReadLine(), out x);
        double preva = (x * x * x * x) / (24);
        double newa = (x * x * x * x) / (24);
        double sum = preva;
        int n = 0;
        do
        {
            preva = newa;
            newa = preva * ((-1) * (x * x * x)) / ((3 * n + 5) * (3 * n + 6) * (3 * n + 7));
            sum += newa;
            n++;
            //Console.WriteLine(sum);
        }
        while (Math.Abs(newa - preva) > 0.0);

        Console.WriteLine(sum);
    }
}