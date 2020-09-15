using System;
//4 задача из дз
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(1000*(x%10) + 100*(x/10%10) + 10*(x/100%10) + x/1000 );
            Console.ReadKey();
        }
    }
}
