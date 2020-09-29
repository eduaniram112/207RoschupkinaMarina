using System;

namespace J
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            bool x = double.TryParse(Console.ReadLine(), out a);
            bool y = double.TryParse(Console.ReadLine(), out b);

            if (x == true && y == true) //проверяем что у нас 2 числа
            {
                if (a * a + b * b <= 2 && a * a + b * b >= 1) { Console.WriteLine("True"); }
                else { Console.WriteLine("False"); }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}

