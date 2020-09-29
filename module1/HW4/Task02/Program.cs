using System;
//задача 7 из презентации 4
namespace Task02
{
    class Program
    {
        static void NOKD(ref int a, ref int b)
        {
            int copy_a = a, copy_b = b;
            

            if (b < 0)
                b = -b;
            if (a < 0)
                a = -a;
            while (b > 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            b = copy_a * copy_b / a;

        }
        static void Main(string[] args)
        {
            int a, b;
            bool x  = int.TryParse(Console.ReadLine(), out a);
            bool y = int.TryParse(Console.ReadLine(), out b);
            NOKD(ref a, ref b);
            Console.WriteLine("НОД={0}", a);
            Console.WriteLine("НОК={0}", b);

        }
    }
}
