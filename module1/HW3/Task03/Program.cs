using System;
//1 задача с 14 слайда
namespace Task03
{
    class Program
    {
        static bool g(int x, int y)
        {
            if (Math.Sqrt(x * x + y * y) <= 2)
            {
                if ((y <= 0 && x >= 0) || (x >= 0 && y <= x))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int x,y;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            Console.WriteLine(g(x,y));
        }
    }
}
