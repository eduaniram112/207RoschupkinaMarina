using System;
//3 задача с 14 слайда
namespace Task05
{
    class Program
    {
        static double g(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI * 0.5);
            }

            else
            {
                return Math.Sin(Math.PI * 0.5 * (x - 1));
            }
        }
        static void Main(string[] args)
        {
            double x;
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(g(x).ToString("F3"));
        }
    }
}
