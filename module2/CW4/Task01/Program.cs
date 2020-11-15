using System;
using System.Collections.Generic;
//8 задача из презентации 5
namespace Task01
{
    class Point
    {
        int x;
        int y;
        int z;

        public Point()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;

        }
        public Point(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int X
        {
            get{ return x;}
            set{x = value;}
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        }

        public static double Distance(Point a,Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
        }
    }
    class Triangle : IComparable<Triangle>
    {
        Point a;
        Point b;
        Point c;

        double AB => Point.Distance(a,b);
        double BC => Point.Distance(b,c);
        double AC => Point.Distance(a,c);

        public Triangle()
        {
            this.a = new Point();
            this.b = new Point();
            this.c = new Point();
        }

        public Triangle(Point a1,Point b1, Point c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public Triangle(int x1, int y1,int x2,int y2,int x3,int y3)
        {
            a = new Point(x1, y1, 0);
            b = new Point(x2, y2, 0);
            c = new Point(x3, y3, 0);
        }
        public double Perimetr() { return AB + BC + AC;}

        public double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
        }

        public int CompareTo(Triangle p)
        {
            return this.Square().CompareTo(p.Square());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Point aa = new Point(1, 2, 3);
            Point bb = new Point(4, 5, 6);
            Point cc = new Point(10, 2, 0);
            Console.WriteLine(Point.Distance(aa,new Point()));
            Console.WriteLine(Point.Distance(bb,new Point()));
            Console.WriteLine(Point.Distance(cc,new Point()));

            Console.WriteLine();

            Random r = new Random();
            List<Triangle> Tri = new List<Triangle>();
            int n = r.Next(5, 16);
            for (int i = 0; i < n;i++)
            {
                //Tri.Add( new Triangle(new Point(r.Next(-10, 11), r.Next(-10, 11), 0), new Point(r.Next(-10, 11), r.Next(-10, 11), 0), new Point(r.Next(-10, 11), r.Next(-10, 11), 0)));
                Tri.Add(new Triangle(r.Next(-10, 11), r.Next(-10, 11), r.Next(-10, 11), r.Next(-10, 11), r.Next(-10, 11), r.Next(-10, 11)));
            }
            Tri.Sort();
            foreach (Triangle trig in Tri)
            {
                Console.WriteLine(trig.Square());
            }

        }
    }
}
