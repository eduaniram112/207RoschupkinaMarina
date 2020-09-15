using System;
//1 задача из дз
namespace Task01
{
    class Program
    {
        static int p(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);
            int f = 12 * p(p(x)) + 9 * x * p(x) - 3 * p(x) + 2 * x - 4;
            Console.WriteLine(f);
        }
    }
}
