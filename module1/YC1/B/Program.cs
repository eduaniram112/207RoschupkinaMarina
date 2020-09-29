using System;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool x = int.TryParse(Console.ReadLine(), out a);
            bool y = int.TryParse(Console.ReadLine(), out b);
            if (x == true && y == true)
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
