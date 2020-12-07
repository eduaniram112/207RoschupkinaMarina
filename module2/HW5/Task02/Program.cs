using System;
using MyLib;
namespace Task02
{
    class Program
    {
        static void Main()
        {
            GeomProgr geomProgrObj; // ссылка на объект типа GeomProgr
            bool flag;
            int b, q;
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите начальный член прогрессии: "); b = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель прогрессии: ");
                    q = int.Parse(Console.ReadLine());
                    geomProgrObj = new GeomProgr(b, q); // создаем объект 2
                }
                catch (Exception e)
                { // ловим любые исключения
                    flag = true;
                    Console.WriteLine("Некорректные входные данные! ");
                }
            } while (flag);
        }
    }
}
