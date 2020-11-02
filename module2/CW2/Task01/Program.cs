using System;
namespace DoubleArr
{
    /*Определить класс Circle с полем радиус _r и свойством доступа к нему, 
     * значение радиуса положительное вещественное число. 
     * В классе Circle описать конструктор без параметров и конструктор с 
     * вещественным параметром. Определить свойство S – площадь круга 
     * заданного радиуса.
     * 
     * 
     * В основной программе получить от пользователя 
     * диапазон изменения значения радиуса: (Rmin, Rmax), Rmin, Rmax – 
     * произвольные вещественные числа и величину шага delta разбиения 
     * данного диапазона. Создать объект типа Circle, последовательно 
     * изменяя значение радиуса на delta вычислять и выводить на экран 
     * значение площади круга, ограниченного данной окружностью.
*/
    class Circle
    {
        private double _r;



        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (_r <= 0)
                    throw new ArgumentException("Negative value");
                _r = value;
            }
        }



        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public double L
        {
            get
            {
                return Math.PI * _r * 2;
            }
        }



        public Circle()
        {
            _r = 1;
        }



        public Circle(double radius)
        {
            _r = radius;
        }



        public override string ToString()
        {
            return $"Circle: radius = {_r}, square = {S}";
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            double delta = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());



            Circle[] c = new Circle[n];
            int k = 0;
            double m = 0;
            for (double i = rmin; i <= rmax; i += delta)
            {
                c[k] = new Circle(i);
                Console.WriteLine(c[k].L+ " " + c[k].S);
                if (c[k].S > m) m = c[k].S;
                k++;
            }
            Console.WriteLine(m);
        }
    }
}








