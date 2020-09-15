using System;
//7 задача из дз
namespace Task07
{
    class Program
    {
        public static void part(double x)
        {
            Console.WriteLine("Целая часть: "+(int)x);
            Console.WriteLine("Дробная часть: " + (x - (int)x).ToString("F3"));


        }
        public static void func(double x)
        {
            Console.WriteLine("Корень: " + Math.Sqrt(x).ToString("F3"));
            Console.WriteLine("Квадрат: " + (x*x).ToString("F3"));


        }
        static void Main(string[] args)
        {
            double a;
            double.TryParse(Console.ReadLine(), out a);
            part(a);
            func(a);
            Console.ReadKey();
        }
    }
}
