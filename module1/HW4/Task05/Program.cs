using System;
//3 задача с 10 слайда 4 презентации
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            double d = 0.05,y,x=1;
            bool q = int.TryParse(Console.ReadLine(), out a);
            bool w = int.TryParse(Console.ReadLine(), out b);
            bool z = int.TryParse(Console.ReadLine(), out c);
            Console.WriteLine("Hello World!");
            while (x <= 2)
            {
                if (x < 1.2)
                {
                    y = a * x * x + b * x + c;
                }
                if (x == 1.2)
                {
                    y = a / x + Math.Sqrt(x * x + 1);
                }
                else
                {
                    y =(a+b*x)/ Math.Sqrt(x * x + 1);
                }
                x += d;
                Console.WriteLine("x={0} y={1}", x.ToString("F3"), y.ToString("F3"));
            }
        }
    }
}
