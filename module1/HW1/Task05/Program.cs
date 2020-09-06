using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b = 0;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("c = " + (Math.Sqrt(a*a+b*b)).ToString("F2"));
            
            Console.ReadKey();

        }
    }
}
