using System;
using System.Globalization;
//6 задача из дз
namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double c = a * b / 100.0;
            Console.WriteLine(c.ToString("C", new CultureInfo("ru-RU")));

        }
    }
}
