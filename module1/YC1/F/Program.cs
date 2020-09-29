using System;

namespace F
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool x = double.TryParse(Console.ReadLine(), out a);
            bool y = double.TryParse(Console.ReadLine(), out b);

            if (x == true && y == true && a>0 && b>0) //проверяем что у нас 2 положительных числа
            {
                double c = Math.Sqrt(a * a + b * b);
                Console.WriteLine(c.ToString("F5"));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
