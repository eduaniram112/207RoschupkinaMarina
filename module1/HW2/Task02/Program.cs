using System;
//2 задача из дз
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);
            int a = Math.Max(x % 10, Math.Max(x / 100, x / 10 % 10));
            int c = Math.Min(x % 10, Math.Min(x / 100, x / 10 % 10));
            int b = x % 10 + x / 100 + x / 10 % 10 - a - c;
            Console.WriteLine(a * 100 + b * 10 + c);
        }
    }
}
