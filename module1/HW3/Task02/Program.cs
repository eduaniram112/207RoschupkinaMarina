using System;
//2 задача с 13 слайда
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string s = "";
            int.TryParse(Console.ReadLine(), out x) ;
            while (x > 0)
            {
                if (x % 10 != 0)
                {
                    s += x % 10;
                }
                x /= 10;
            }
            Console.WriteLine(int.Parse(s));
                    
        }
    }
}
