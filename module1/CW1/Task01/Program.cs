using System;
//1 задача из классной
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("плохо");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("сойдет");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("хорошо");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("отлично");
                    break;
                case 10:
                    Console.WriteLine("изумительно");
                    break;
            }
            Console.ReadKey();

        }
    }
}
