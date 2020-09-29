using System;
//2 задача с 10 слайда 4 презентации
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int nsum=0, n = 0;
            while (nsum>-1000)
            {
                int a;
                bool x = int.TryParse(Console.ReadLine(), out a);
                if (x == false){  break; } // чтобы выйти
                if (a < 0) { nsum += a; n++; }
               
                
            }
            Console.WriteLine(nsum/n);
        }
    }
}
