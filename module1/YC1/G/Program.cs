using System;

namespace G
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            bool x = double.TryParse(Console.ReadLine(), out a);


            if (x == true && a >= 0) //проверяем что у нас положительное число
            {
                
                Console.WriteLine((int)((a - (int)a) * 10));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
