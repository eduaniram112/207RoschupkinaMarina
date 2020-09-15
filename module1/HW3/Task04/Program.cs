using System;
//2 задача с 14 слайда
namespace Task04
{
    class Program
    {
        static double g(double x, double y)
        {
            if (x<y && x > 0)
            {
                return x + Math.Sin(y);
            }
            else if (x>y && x < 0)
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * y * x;
            }
        }
        static void Main(string[] args)
        {
            double x, y;
            double.TryParse(Console.ReadLine(), out x);
            double.TryParse(Console.ReadLine(), out y);
            Console.WriteLine(g(x, y).ToString("F3"));
        }
    }
}
