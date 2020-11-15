using System;
using System.Collections.Generic;
//10 задача из презентации 5-6
namespace Task02
{
    class Circle
    {
        int x;
        int y;
        int r;
        public Circle(int X, int Y,int R)
        {
            x = X;
            y = Y;
            r = R;
        }
        public bool Touching(Circle b)
        {
            double d = Math.Sqrt(Math.Pow(x - b.x, 2) + Math.Pow(y - b.y, 2));
            if (d <= r + b.r) return true;
            else return false;
        }
        public override string ToString()
        {
            return "x = "+ x +" y = " + y +" r = "+ r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество кругов");
            bool z = int.TryParse(Console.ReadLine(), out n);

            List<Circle> le = new List<Circle>();
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                int x = r.Next(1, 16);
                int y = r.Next(1, 16);
                int rad = r.Next(1, 16);

                le.Add(new Circle(x, y, rad));
            }
            Console.WriteLine("Круги:");
            foreach (Circle a in le)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            Console.WriteLine("Круги которые касаются михаила круга:");
            Circle mikhail = new Circle(0, 0, 1);
            foreach (Circle a in le)
            {
                if (a.Touching(mikhail)) Console.WriteLine(a);
            }
        }
    }
}
