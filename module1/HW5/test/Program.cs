using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные программы:
            double angle,   // Введенный угол в радианах
                   x,         // Аргумент x (приведенный угол)
                   sin,       // Сумма ряда (текущая)
                   sinOld,    // Сумма ряда (предыдущая)
                   memb;      // Очередной член ряда 

            do
            {
                Console.Write("Введите значение угла: ");
            }
            while (!double.TryParse(Console.ReadLine(), out angle) || angle <= 0);

            x = angle % (2 * Math.PI);    // приведение угла
                                          // Цикл вычисления суммы ряда (след. слайд)
                                          // Вывод результатов (angle, sin) 
                                          // Вывод  значения Math.Sin(angle)
                                          // Завершение кода программы

            int m; // число просуммированных членов ряда        
            for (m = 1, sin = memb = x, sinOld = 0; sin != sinOld; m++)
            {
                Console.WriteLine("sin({0})={1} or = {2} \tmemb = {3}", x, sin, Math.Sin(x), memb);
                sinOld = sin;
                memb *= -x * x / 2 / m / (2 * m + 1);
                sin += memb;
            }
            Console.ReadKey();
        }
    }
}
