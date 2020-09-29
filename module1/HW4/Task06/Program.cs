using System;
//4 задача с 10 слайда 4 презентации
namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int m,n;
            bool x = int.TryParse(Console.ReadLine(), out m);
            bool y = int.TryParse(Console.ReadLine(), out n);
            if (m < 64 && n < 64)
            {
                ulong a = 0, one = 1;
             
                a |= one << n;
                //Console.WriteLine(a);
                if (n == m){ a <<= 1;}
                else {a |= one << m;}
                
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("переполнение");
            }
        }
    }
}
