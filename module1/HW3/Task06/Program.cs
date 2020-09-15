using System;
//4 задача с 14 слайда
namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);

            if (x % 100 < y % 100 && x%100 < z % 100)
            {
                Console.WriteLine(x);
            }
            else if (y % 100 < x % 100 && y % 100 < z % 100)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(z);
            }



        }
    }
}
