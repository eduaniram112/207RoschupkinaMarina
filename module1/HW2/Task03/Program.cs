using System;
using System.Numerics;
//3  задача из дз
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double d = b * b - 4 * a * c;

            object x1 = d < 0 ? (-b + Complex.Sqrt(d)) / 2 / a : (-b + Math.Sqrt(d)) / 2 / a;
            object x2 = d < 0 ? (-b - Complex.Sqrt(d)) / 2 / a : (-b - Math.Sqrt(d)) / 2 / a;

            //первое число - действительная часть, второе - мнимая
            Console.WriteLine(x1); 
            Console.WriteLine(x2);
            Console.ReadKey();


        }
    }
}
