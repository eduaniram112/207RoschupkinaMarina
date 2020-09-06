using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double u, r = 0;
            double.TryParse(Console.ReadLine(), out u);
            double.TryParse(Console.ReadLine(), out r);
            Console.WriteLine("I = " + (u / r).ToString("F3"));
            Console.WriteLine("P = " + (u*u / r).ToString("F3"));
            Console.ReadKey();


        }
    }

}
