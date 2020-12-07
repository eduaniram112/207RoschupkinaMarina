using System;
using MyLib;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = 'к', finish = 'ю';
            do
            {
                MyStrings testString = new RusString(start, finish, 10);
                MyStrings testString1 = new LatString('a', 'q', 7);
                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString1);
                Console.WriteLine(testString1.CountLetter('b'));
                // тестируем неверные входные данные
                try
                {
                    testString = new RusString(start, finish, -11);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                }
                try
                {
                    testString1 = new LatString('6', 'x', 6);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Состояние объекта не изменено");// если объект не сформирован
                }
                Console.WriteLine(testString);
                Console.WriteLine(testString.CountLetter('о'));
                Console.WriteLine(testString1);
                Console.WriteLine(testString1.CountLetter('j'));
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
