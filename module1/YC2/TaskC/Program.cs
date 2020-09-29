using System;

partial class Program
{
    static void Main(string[] args)
    {
        int a,b, sum = 0;
        bool x = int.TryParse(Console.ReadLine(), out a);
        bool y = int.TryParse(Console.ReadLine(), out b);

        if (x == true && y==true && a<b) //проверяем что у нас целые числа
        {
            while (a < b)

            {
                if (a % 2 == 0) { Console.WriteLine(a); }
                a += 1;
            }
            
        }
        else
        {
            Console.WriteLine("Incorrect input");
        }


    }

}
