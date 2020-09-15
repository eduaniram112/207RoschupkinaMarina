using System;
//5 задача из дз
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double m = Math.Max(a, Math.Max(b, c));
            String ans = m < a + b + c - m ? "Существует" : "Не существует";
            Console.WriteLine(ans);
        }
    }
}
