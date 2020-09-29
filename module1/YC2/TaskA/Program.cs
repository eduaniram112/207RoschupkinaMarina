using System;

class Program
{
    static void Main(string[] args)
    {
        uint a,sum=0;
        bool x = uint.TryParse(Console.ReadLine(), out a);

        if (x == true ) //проверяем что у нас целое число 
        {
            while (a > 0)

            {
                sum += a % 10;
                a /= 10;
            }
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }


    }
}

