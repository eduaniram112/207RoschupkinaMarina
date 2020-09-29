using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool x = int.TryParse(Console.ReadLine(), out a);

            if (x == true && a>0)
            {
                Console.WriteLine(a%10);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
