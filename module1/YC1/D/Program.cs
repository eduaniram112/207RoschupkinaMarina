using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool x = int.TryParse(Console.ReadLine(), out a);
            bool y = int.TryParse(Console.ReadLine(), out b);

            if (x == true && y == true) //проверяем что у нас 2 целых числа
            {
                if (a > b) { Console.WriteLine("First"); }
                else if (a == b) { Console.WriteLine("Equal"); }
                else { Console.WriteLine("Second"); }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
