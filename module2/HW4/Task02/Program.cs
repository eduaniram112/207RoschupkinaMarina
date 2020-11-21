using System;
using figures;
//задача 2 из презентации 7-8
namespace Task02
{ 
    class Program
    {
        static Point[] FigArray()
        {
            Random r = new Random();
            Point[] arr = new Point[r.Next(0, 11)];
            for (int i = 0; i < arr.Length; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    arr[i] = new Circle(r.NextDouble() + r.Next(10,100), r.NextDouble() * 10 + r.Next(10, 100), r.NextDouble() * 10 + r.Next(10, 100) );
                }
                else
                {
                    arr[i] = new Square(r.NextDouble() + r.Next(10, 100), r.NextDouble() + r.Next(10, 100), r.NextDouble() + r.Next(10, 100));
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Point p = new Point();
            Console.WriteLine(p.Display());
            Console.WriteLine("p.Area для Point = " + p.Area+"\n");
            p = new Circle(1, 2, 6);
            Console.WriteLine(p.Display());
            Console.WriteLine("p.Area для Circle = " + p.Area + "\n");
            p = new Square(3, 5, 8);
            Console.WriteLine(p.Display());
            Console.WriteLine("p.Area для Square = " + p.Area + "\n\n");


            Point[] figs = FigArray();
            int c=0, s=0;
            foreach (Point f in figs)
            {
                if (f is Circle) c++;
                if (f is Square) s++;
                Console.WriteLine(f.Display());
            }

            Console.WriteLine();
            Console.WriteLine("Кругов: " + c);
            Console.WriteLine("Квадратов: " + s);
            Console.WriteLine();

            Array.Sort(figs);
            foreach (Point f in figs)
            {
                Console.WriteLine(f.Display());
            }
        }
    }
}
