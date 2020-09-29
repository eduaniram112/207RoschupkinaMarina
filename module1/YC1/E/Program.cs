using System;

namespace E
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool x = int.TryParse(Console.ReadLine(), out a);

            if (x == true && a>=1000) //проверяем что у наc целое 4-х значное число больше 0
            {
                if (a%10 == a/1000 && a/10%10 == a / 100 % 10) { Console.WriteLine("True"); }
                else { Console.WriteLine("False"); }
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
    }
}
